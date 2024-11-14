using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text.RegularExpressions;
using WinFormApp.Data;
using WinFormApp.Models;
using WinFormApp.Services.GridService;
using WinFormApp.Services.MyValidationService;

namespace WinFormApp.ViewModels
{
    [POCOViewModel]
    public class PersonViewModel
    {
        // Inicializace sluzeb
        protected virtual IMessageBoxService MessageBoxService { get { throw new NotImplementedException(); } }
        // Sluzba umoznuje pristup k valstnostem a hodnotam v GridView
        protected IGridViewService GridViewService { get { return this.GetService<IGridViewService>(); } }
        // Sluzba umoznuje aplikovat validacni metody pro kontrolu vstupnich dat
        protected IMyValidationService ValidationService { get { return this.GetService<IMyValidationService>(); } }

        public Person _person { get; set; }
        private AppDataContext _dbContext = null!;
        public virtual BindingSource PersonBindingSource { get; set; } = null!;

        public virtual Person Person
        {
            get => _person;
            set     // nastavuje novou hodnotu pro _person a informuje UI o zmene
            {
                _person = value;
                // ohlasuje zmeny hodnoty Person at uz v UI(layout ctrl) nebo ViewModelu
                this.RaisePropertyChanged(x => x.Person);
            }
        }

        protected PersonViewModel()
        {
            _dbContext = new AppDataContext();
            _person = new Person();
            PersonBindingSource = new BindingSource();
            LoadPeopleAsync();  // Nacteni osob z databaze
        }

        // Metoda pro vytvoreni instance ViewModelu
        public static PersonViewModel Create()
        {
            return ViewModelSource.Create(() => new PersonViewModel());
        }

        private async void LoadPeopleAsync()
        {
            try
            {
                // nacteni dat z tabulky People pomoci Entity Framework Core
                await _dbContext.People.LoadAsync();
                // prirazeni nactenych dat do BindingSource pro nastaveni vazby mezi View a VM
                PersonBindingSource.DataSource = _dbContext.People.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                MessageBoxService.ShowMessage($"Error loading data: {ex.Message}");
            }
        }

        #region AddPerson
        public async void AddPerson()
        {
            // Slovnik sloupcu, ktere je treba projit kvuli duplicite pri vkladani novych dat
            Dictionary<string, string> validateFields = new Dictionary<string, string>
            {
                {"Email", Person.Email },
                {"PhoneNumber", Person.PhoneNumber }
            };

            // Double-check - kontrola po prazdnych kolonkach
            if (ValidationService.CheckForEmptyFields<Person>(Person))
            {
                // filtrace nadbytecnych mezer a kapitalizace zacatecnich pismen
                Person.FirstName = FilterAndCapitalizeInputs(Person.FirstName);
                Person.LastName = FilterAndCapitalizeInputs(Person.LastName);

                // zkontroluje duplicitu nove vlozenych dat vuci "databazi" (gridview)
                // parametrem - seznam sloupcu pro kontrolu
                if (CheckForDataDuplicity(validateFields))
                {
                    // ulozeni dat do databaze skrze EF core
                    _dbContext.People.Add(Person);
                    await _dbContext.SaveChangesAsync();
                    // odstrani text ze vstupnich kolonek (layout controls)
                    ClearLayoutControls();
                }
            }
        }

        public bool CheckForDataDuplicity(Dictionary<string, string> validateFields)
        {
            foreach (var item in validateFields)
            {
                if (ValidationService.DoesDataExist(-1, item.Key, item.Value, GridViewService, MessageBoxService))
                    return false;
            }
            return true;
        }

        public string FilterAndCapitalizeInputs(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            // Trim leading and trailing spaces
            string trimmedInput = input.Trim();

            // Use Regex to replace multiple spaces with a single space
            string normalizedInput = Regex.Replace(trimmedInput, @"\s+", " ");

            // Capitalize the first letter of each word
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string capitalizedInput = textInfo.ToTitleCase(normalizedInput.ToLower());

            return capitalizedInput;
        }

        private void ClearLayoutControls()
        {
            Person = new Person();
        }
        #endregion AddPerson

        #region GridEventHandlers
        // Metoda pro zachyceni a validaci zmen v Grid View
        public void OnValidatingEditor(BaseContainerValidateEditorEventArgs e)
        {
            // seznam sloupcu - kontrola formatu vstupnich hodnot
            Dictionary<string, Func<object, string>> columnValidations = new Dictionary<string, Func<object, string>>()
            {
                { "BirthDate", ValidationService.ValidateBirthdate },
                { "PhoneNumber", ValidationService.ValidatePhone },
                { "Email", ValidationService.ValidateEmail}
            };
            string fieldName = GridViewService.GetFocusedColumnFieldName(); // vraci upravovany sloupec 

            if (columnValidations.ContainsKey(fieldName))
            {
                Func<object, string> validationMethod = columnValidations[fieldName];
                string errorMessage = validationMethod(e.Value);
                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    e.Valid = false;
                    e.ErrorText = errorMessage;
                }
            }
        }

        // Zachycuje finalni zmeny pro ulozeni do databaze
        public async void OnCellValueChanged(CellValueChangedEventArgs e)
        {
            var rowHandle = e.RowHandle;
            var editedColumn = e.Column;
            var editedValue = e.Value.ToString();
            bool isValid = true;

            // provadi-li se zmena na nekterych ze sloupcu => kontrola duplicity
            if (editedColumn.FieldName == "PhoneNumber")
            {
                if (ValidationService.DoesDataExist(rowHandle, editedColumn.FieldName, editedValue!, GridViewService, MessageBoxService))
                {
                    GridViewService.SetColumnError(rowHandle, editedColumn, "Phone number already in use");
                    isValid = false;
                }
            }
            else if (editedColumn.FieldName == "Email")
            {
                if (ValidationService.DoesDataExist(rowHandle, editedColumn.FieldName, editedValue!, GridViewService, MessageBoxService))
                {
                    GridViewService.SetColumnError(rowHandle, editedColumn, "Email alredy in use");
                    isValid = false;
                }
            }
            // duplicity nebyly nalezeny => uloz zmeny do db
            if (isValid)
            {
                // odstran chybove zpravy a ikony
                GridViewService.SetColumnError(rowHandle, editedColumn, string.Empty);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async void DeleteSelectedRows()
        {
            // Vytvoreni noveho dbcontextu pro dany pozadavek
            // (jen pro jistotu, aby nedoslo k naruseni nejakych procesu)
            // po splneni pozadavku se novy dbcontext uvolni
            using var scopedDbContext = new AppDataContext();
            Int32[] selectedRowHandles = GridViewService.GetSelectedRows();
            var confirmationMessage = MessageBoxService.ShowMessage("Do you really want to delete selected row(s)?",
                "Confirmation", MessageButton.YesNo);

            if (confirmationMessage == MessageResult.Yes)
            {
                // nalezni oznacene radky a postupne odstran z gridu a databaze
                foreach (var rowHandle in selectedRowHandles)
                {
                    if (GridViewService.GetRow(rowHandle) is Person person)
                    {
                        scopedDbContext.People.Attach(person);
                        scopedDbContext.Remove(person);
                    }
                }
                GridViewService.DeleteSelectedRows();
                await scopedDbContext.SaveChangesAsync();   // ulozeni zmen v databazi
            }
        }
        #endregion GridEventHandlers

        // Metoda uvolni vyuzivane zdroje az nebudou potreba
        // zabrani se memory-leaks a dalsim problemum
        public void Dispose()
        {
            _dbContext?.Dispose();
        }

    }
}