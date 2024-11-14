using DevExpress.XtraEditors.DXErrorProvider;
using System.Text.RegularExpressions;
using WinFormApp.Services;

namespace WinFormApp.Views.MyValidationRules
{
    public class CompanyIDValidationRule : ValidationRule
    {
        MyValidationHelper validationHelper = new MyValidationHelper();
        public override bool Validate(Control control, object value)
        {
            //if (value is string companyID)
            //{
            //    // Validation: check if the value is exactly 8 digits
            //    if (!Regex.IsMatch(companyID, @"^\d{8}$"))
            //    {
            //        ErrorText = "Company identification number must contain exactly 8 digits.";
            //        return false;
            //    }

            //    return true;
            //}
            //ErrorText = "Company identification number is required.";
            //return false;

            string error = validationHelper.ValidateCompanyID(value);
            if (!string.IsNullOrEmpty(error))
            {
                ErrorText = error;
                return false;
            }
            return true;
        }
    }
}
