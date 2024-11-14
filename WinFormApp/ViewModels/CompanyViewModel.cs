using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WinFormApp.Data;
using WinFormApp.Models;
using WinFormApp.Services.GridService;
using WinFormApp.Services.MyValidationService;

namespace WinFormApp.ViewModels
{
    public class CompanyViewModel
    {
        protected virtual IMessageBoxService MessageBoxService { get { throw new NotImplementedException(); } }
        protected IGridViewService GridViewService { get { return this.GetService<IGridViewService>(); } }
        protected IMyValidationService ValidationService { get { return this.GetService<IMyValidationService>(); } }

        public Company _company { get; set; }
        private AppDataContext _companyDbContext = null!;
        public virtual BindingSource CompanyBindingSource { get; set; }

        public virtual Company Company
        {
            get => _company;
            set
            {
                _company = value;
                this.RaisePropertyChanged(x => x.Company);
            }
        }

        protected CompanyViewModel()
        {
            _company = new Company();
            _companyDbContext = new AppDataContext();
            CompanyBindingSource = new BindingSource();
            LoadCompaniesAsync();
        }
        
        public static CompanyViewModel Create()
        {
            return ViewModelSource.Create(() => new CompanyViewModel());
        }

        public async void LoadCompaniesAsync()
        {
            try
            {
                await _companyDbContext.Companies.LoadAsync();
                CompanyBindingSource.DataSource = _companyDbContext.Companies.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                MessageBoxService.ShowMessage($"Error loading data from Companies table: {ex.Message}");
            }
        }

        #region AddCompany

        public async void AddCompany()
        {
            Dictionary<string, string> validateFields = new Dictionary<string, string>
            {
                {"CompanyID", Company.CompanyID },
                {"CompanyName", Company.CompanyName},
                {"PhoneNumber", Company.PhoneNumber},
                {"Email", Company.Email},
            };

            if (ValidationService.CheckForEmptyFields<Company>(Company))
            {
                if (CheckForDataDuplicity(validateFields))
                {
                    _companyDbContext.Companies.Add(Company);
                    await _companyDbContext.SaveChangesAsync();
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
        
        private void ClearLayoutControls()
        {
            Company = new Company();
        }
        #endregion AddCompany

        public async void DeleteSelectedCompanyRecords()
        {
            using var scopedDbContext = new AppDataContext();
            Int32[] selectedRowHandles = GridViewService.GetSelectedRows();
            var confirmationMessage = MessageBoxService.ShowMessage("Do you really want to delete selected row(s)?",
                "Confirmation", MessageButton.YesNo);

            if (confirmationMessage == MessageResult.Yes)
            {
                foreach (var rowHandle in selectedRowHandles)
                {
                    if (GridViewService.GetRow(rowHandle) is Company company)
                    {
                        scopedDbContext.Companies.Attach(company);
                        scopedDbContext.Remove(company);
                    }
                }
                GridViewService.DeleteSelectedRows();
                await scopedDbContext.SaveChangesAsync();
            }
        }

        #region BindedEventHandlers
        public async void OnCellValueChanged(CellValueChangedEventArgs e)
        {
            var rowHandle = e.RowHandle;
            var editedColumn = e.Column;
            var editedValue = e.Value.ToString();
            bool isValid = true;

            if (editedColumn.FieldName == "CompanyID")
            {
                if(ValidationService.DoesDataExist(rowHandle, editedColumn.FieldName, editedValue!, GridViewService, MessageBoxService))
                {
                    GridViewService.SetColumnError(rowHandle, editedColumn, "Company with this ID already exists");
                    isValid = false;
                }
            }
            else if (editedColumn.FieldName == "CompanyName")
            {
                if(ValidationService.DoesDataExist(rowHandle, editedColumn.FieldName, editedValue!, GridViewService, MessageBoxService))
                {
                    GridViewService.SetColumnError(rowHandle, editedColumn, "Company with this name already exists");
                    isValid = false;
                }
            }
            else if (editedColumn.FieldName == "PhoneNumber")
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

            if (isValid)
            {
                GridViewService.SetColumnError(rowHandle, editedColumn, string.Empty);
                await _companyDbContext.SaveChangesAsync();
            }
        }
        
        public void OnValidatingEditor(BaseContainerValidateEditorEventArgs e)
        {
            Dictionary<string, Func<object, string>> columnValidations = new Dictionary<string, Func<object, string>>()
            {
                { "CompanyID", ValidationService.ValidateCompanyID},
                { "CompanyName", ValidationService.ValidateCompanyName},
                { "PhoneNumber", ValidationService.ValidatePhone },
                { "Email", ValidationService.ValidateEmail}
            };

            string fieldName = GridViewService.GetFocusedColumnFieldName();
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
        #endregion BindedEventHandlers
        public void Dispose()
        {
            _companyDbContext.Dispose();
        }

    }
}
