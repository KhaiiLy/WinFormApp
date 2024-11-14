using DevExpress.XtraEditors.DXErrorProvider;
using WinFormApp.Services;

namespace WinFormApp.Views.MyValidationRules
{
    public class BirthdateValidationRule : ValidationRule
    {
        MyValidationHelper myValidationHelper = new MyValidationHelper();

        public override bool Validate(Control control, object value)
        {
            string error = myValidationHelper.ValidateBirthdate(value);

            if (!string.IsNullOrEmpty(error))
            {
                ErrorText = error;
                return false;
            }
            return true;
        }
    }
}
