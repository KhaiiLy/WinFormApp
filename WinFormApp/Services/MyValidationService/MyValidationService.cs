using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using WinFormApp.Services.GridService;

namespace WinFormApp.Services.MyValidationService
{
    public class MyValidationService : IMyValidationService
    {
        protected virtual IMessageBoxService MessageBoxService { get { throw new NotImplementedException(); } }
        protected IGridViewService GridViewService { get { return this.GetService<IGridViewService>(); } }
        protected IMyValidationService ValidationService { get { return this.GetService<IMyValidationService>(); } }
        private readonly MyValidationHelper validationHelper = new MyValidationHelper();    // /Services/MyValidationHelper.cs

        // Metody Validate... vyuzivaji metod tridy MyValidationHelper
        public string ValidateBirthdate(object value)
        {
            return validationHelper.ValidateBirthdate(value);
        }

        public string ValidateEmail(object value)
        {
            return validationHelper.ValidateEmail(value);
        }

        public string ValidatePhone(object value)
        {
            return validationHelper.ValidatePhone(value);
        }

        public string ValidateCompanyID(object value)
        {
            return validationHelper.ValidateCompanyID(value);
        }

        public string ValidateCompanyName(object value)
        {
            return validationHelper.ValidateCompanyName(value);
        }
        // Metoda kontroluje duplicitu dat v "databazi" (v grid view)
        public bool DoesDataExist(int rowHandle, string fieldName, string value, IGridViewService gridViewService, IMessageBoxService messageBoxService)
        {
            for (int i = 0; i < gridViewService.DataRowCount; i++)
            {
                if (i != rowHandle)
                {
                    var rowValue = gridViewService.GetCellValue(i, fieldName).ToString();
                    // podminka if porovnava string hodnoty a ignoruje velikost pismen
                    // test123 == TEst123 -> true
                    if(!string.IsNullOrWhiteSpace(rowValue) && rowValue.Equals(value, StringComparison.OrdinalIgnoreCase))
                    {
                        messageBoxService.ShowMessage($"{fieldName} {value} is already in use.");
                        return true;
                    }
                }
            }
            return false;
        }

        // Metoda kontroluje, zda ma kazdy prvek objektu hodnotu
        // objekty typu: Person, Company
        public bool CheckForEmptyFields<T>(T dataObject)
        {
            foreach (var property in typeof(T).GetProperties())
            {
                if (property.Name == "Id") continue;
                var propValue = property.GetValue(dataObject);
                if (propValue == null || string.IsNullOrWhiteSpace((propValue.ToString())))
                {
                    MessageBoxService.ShowMessage("All fields are required.");
                    return false;
                }
            }
            return true;
        }
    
        
    }
}
