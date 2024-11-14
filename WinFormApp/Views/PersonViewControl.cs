using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using WinFormApp.Services.GridService;
using WinFormApp.Services.MyValidationService;
using WinFormApp.ViewModels;
using WinFormApp.Views.MyValidationRules;


namespace WinFormApp.Views
{
    public partial class PersonViewControl : UserControl
    {
        private MVVMContextFluentAPI<PersonViewModel> fluentApi { get; set; }

        public PersonViewControl()
        {
            InitializeComponent();

            // Inicializace mvvmContextu
            // Nastaveni ViewModelu pro typ (PersonViewModel) v kontextu MVVM
            // Nastaveni Fluent API k ziskani kontextu ViewModelu
            var personVM = PersonViewModel.Create();
            mvvmPersonContext.SetViewModel(typeof(PersonViewModel), personVM);
            fluentApi = mvvmPersonContext.OfType<PersonViewModel>();

            // Registrace sluzeb pro praci s gridem
            // Registrace sluzeb pro validaci vstupnich hodnot
            mvvmPersonContext.RegisterService(new GridViewService(gridView1));
            mvvmPersonContext.RegisterService(new MyValidationService());

           
            InitBindings();         // Inicializace vazeb mezi ViewModelem a View
            SetupLayoutControl();   // Nastaveni Layout Controlu - povolene formatz vstup. hodnot
            SetupGridControls();    
            SetupValidationRules();         // Nastaveni Custom validacnich pravidel => /Views/MyValidationRules
            UpdateDeleteBtnState(false);    // Uzamkne Delete Button - odemknuti po vyberu radku v gridu

            // Povoli opusteni editoru pri vlozeni nespravne hodnody
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        // Nastaveni vazeb mezi View a ViewModel
        // - propojeni layout controls, gridu, event handleru, atd.
        private void InitBindings()
        {
            // Propojeni LayoutControl (TextEdits) s Person objektem
            fluentApi.SetBinding(dataLayoutControl1, layout => layout.DataSource, x => x.Person);
            // Propojeni GridControl s databazi = data z tabulky People
            fluentApi.SetBinding(gridControl1, grid => grid.DataSource, x => x.PersonBindingSource);
            // Event pro pridani nove Osoby do databaze
            // ViewModel metoda se zavola, pokud projde validace vstup. hodnot
            fluentApi.WithEvent(sbtnAddPerson, "Click")
                .EventToCommand(x => x.AddPerson, (args) =>
                {
                    bool result = dxValidationProvider1.Validate();
                    if (!result)
                    {
                        MessageBox.Show("Data might be in incorrect format or some fields are left emtpy.");
                        return false;
                    }
                    return true;
                });
            // Propojeni Buttonu pro mazani zaznamu z gridu
            fluentApi.BindCommand(sbtnDelete, x => x.DeleteSelectedRows());
            // Event reaguje na zmenu dat v grid view
            fluentApi.EventToCommand<CellValueChangedEventArgs>(gridView1, "CellValueChanged", e => e.OnCellValueChanged(null!), x => x);
            // Event pro validaci editovanych dat v grid view
            fluentApi.EventToCommand<BaseContainerValidateEditorEventArgs>(gridView1, "ValidatingEditor",
                x => x.OnValidatingEditor(null!));
        }

        private void SetupLayoutControl()
        {
            FirstNameTextEdit.Properties.MaskSettings.Configure<MaskSettings.RegExp>(settings =>
            {
                settings.MaskExpression = "[a-zA-Zá-žÁ-Ž0-9 ]{2,30}";
                settings.ShowPlaceholders = false;
            });

            LastNameTextEdit.Properties.MaskSettings.Configure<MaskSettings.RegExp>(settings =>
            {
                settings.MaskExpression = "[a-zA-Zá-žÁ-Ž0-9 ]{2,30}";
                settings.ShowPlaceholders = false;
            });

            // Format zobrazeni data narozeni
            BirthDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            BirthDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            BirthDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            BirthDateEdit.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            BirthDateEdit.Properties.EditMask = "dd/MM/yyyy";
            BirthDateEdit.Properties.NullDate = DateTime.MinValue;
            BirthDateEdit.Properties.MaxValue = DateTime.Today;

            PhoneNumberTextEdit.Properties.MaskSettings.Configure<MaskSettings.RegExp>(settings =>
            {
                settings.MaskExpression = @"\+\d{1,3} \d{3} \d{3} \d{3}";
                settings.ShowPlaceholders = true;
            });

            EmailTextEdit.Properties.MaskSettings.Configure<MaskSettings.RegExp>(settings =>
            {
                settings.MaskExpression = @"\w+([-._]\w*)*@\w+([-.]\w*)*\.\w*([-.]\w*)*";
                settings.ShowPlaceholders = false;
            });
        }

        private void SetupValidationRules()
        {
            dxValidationProvider1.ValidationMode = ValidationMode.Auto;
            dxValidationProvider1.SetValidationRule(FirstNameTextEdit, new LengthValidationRule());
            dxValidationProvider1.SetValidationRule(LastNameTextEdit, new LengthValidationRule());
            dxValidationProvider1.SetValidationRule(BirthDateEdit, new BirthdateValidationRule());
            dxValidationProvider1.SetValidationRule(PhoneNumberTextEdit, new PhoneNumValidationRule());
            dxValidationProvider1.SetValidationRule(EmailTextEdit, new EmailValidationRule());
        }

        public void SetupGridControls()
        {
            // Schovani ID sloupce, povoleni Multiselectu s Checkbox prvky
            gridView1.Columns[0].Visible = false;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;

            // Zobrazeni data narozeni ve vhodnem formatu
            RepositoryItemDateEdit dateEdit = new RepositoryItemDateEdit
            {
                DisplayFormat = { FormatString = "dd/MM/yyyy", FormatType = DevExpress.Utils.FormatType.DateTime },
                Mask = { EditMask = "dd/MM/yyyy" },
                UseMaskAsDisplayFormat = true,
            };

            RepositoryItemTextEdit phoneEdit = new RepositoryItemTextEdit
            {
                Mask = {
                    EditMask = @"\+\d{1,3} \d{3} \d{3} \d{3}",
                    MaskType = MaskType.RegEx,
                    ShowPlaceHolders = false,
                },
                UseMaskAsDisplayFormat = true,
            };

            RepositoryItemTextEdit emailEdit = new RepositoryItemTextEdit
            {
                Mask = {
                    EditMask = @"\w+([-._]\w*)*@\w+([-.]\w*)*\.\w*([-.]\w*)*",
                    MaskType = MaskType.RegEx,
                    ShowPlaceHolders = false,
                },
                UseMaskAsDisplayFormat = true,
            };

            // nastaveni povoleneho formatu pri editaci dat
            gridView1.Columns["BirthDate"].ColumnEdit = dateEdit;
            gridView1.Columns["Email"].ColumnEdit = emailEdit;
            gridView1.Columns["PhoneNumber"].ColumnEdit = phoneEdit;
            // reakce na event - vyber radku
            gridView1.SelectionChanged += GridView1_SelectionChanged;
        }

        // Detekce vybranych radku pomoci CheckBox prvku
        // neni-li vybran radek, Delete Button je uzamcen
        private void GridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var view = sender as GridView;
            if (view != null)
            {
                bool anyRowSelected = view.SelectedRowsCount > 0;

                UpdateDeleteBtnState(anyRowSelected);
            }
        }

        private void UpdateDeleteBtnState(bool anyRowSelected)
        {
            sbtnDelete.Enabled = anyRowSelected;
        }

        // Metoda pro odstraneni error zprav a ikon
        private void ClearValidationErrors(object? sender, EventArgs e)
        {
            foreach (Control control in dataLayoutControl1.Controls)
            {
                dxValidationProvider1.RemoveControlError(control);
            }
        }
    }
}
