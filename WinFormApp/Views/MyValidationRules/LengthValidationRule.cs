using ValidationRule = DevExpress.XtraEditors.DXErrorProvider.ValidationRule;

namespace WinFormApp.Views.MyValidationRules
{
    public class LengthValidationRule : ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            var text = value as string;
            if (string.IsNullOrWhiteSpace(text))
            {
                ErrorText = "This field is required";
                return false;
            }
            if (text.Length < 2 || text.Length > 30)
            {
                ErrorText = "Input must contain at least 2 characters.";
                return false;
            }
            return true;
        }
    }
}
