using WinFormApp.Services;
using ValidationRule = DevExpress.XtraEditors.DXErrorProvider.ValidationRule;

namespace WinFormApp.Views.MyValidationRules
{
    public class EmailValidationRule : ValidationRule
    {
        MyValidationHelper myValidationHelper = new MyValidationHelper();

        public override bool Validate(Control control, object value)
        {
            string error = myValidationHelper.ValidateEmail(value);
            if (!string.IsNullOrEmpty(error))
            {
                ErrorText = error;
                return false;
            }
            return true;
        }
    }
}
