using DevExpress.Mvvm;
using WinFormApp.Services.GridService;

namespace WinFormApp.Services.MyValidationService
{
    // Rozhrani pro implementaci potrebnych metod pro validaci vstupnich hodnot
    public interface IMyValidationService
    {
        string ValidateBirthdate(object value);
        string ValidateEmail(object value);
        string ValidatePhone(object value);
        string ValidateCompanyID(object value);
        string ValidateCompanyName(object value);

        bool DoesDataExist(int rowHandle, string fieldName, string value, IGridViewService gridViewService, IMessageBoxService messageBoxService);
        bool CheckForEmptyFields<T>(T dataObject);
    }
}
