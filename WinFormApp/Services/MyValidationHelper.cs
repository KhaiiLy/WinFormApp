using System.Text.RegularExpressions;

namespace WinFormApp.Services
{
    // Trida obsahuje metody pro validaci hodnot
    // vyuzita v:
    //      /Views/MyValidationRules
    //      /Services/MyValidationService
    public class MyValidationHelper
    {
        public string ValidateBirthdate(object value)
        {
            if (value is DateTime birthDate)
            {
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now < birthDate.AddYears(age)) age--;
                if (age < 15) return "User must be at least 15 years old.";
                if (birthDate < new DateTime(1900, 1, 1)) return "Birthdate cannot be earlier than January 1, 1900.";
            }
            else
                return "Please enter a valid date.";
            return string.Empty;
        }

        public string ValidateEmail(object value)
        {
            if (value is string email)
            {
                if (string.IsNullOrEmpty(email)) return "Email is required";
                if (!Regex.IsMatch(email, @"\w+([-._]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                    return "Incorrect email format (e.g. example@something.com)";
            }
            return string.Empty;
        }

        public string ValidatePhone(object value)
        {
            if (value is string phone)
            {
                if (phone == "+") return "Phone number is required";
                if (!Regex.IsMatch(phone, @"\+\d{1,3} \d{3} \d{3} \d{3}"))
                    return "Incorrect phone number format (e.g +123 123 123 123)";
            }
            return string.Empty;
        }

        public string ValidateCompanyID(object value)
        {
            if (value is string companyID)
            {
                if (string.IsNullOrEmpty(companyID)) return "Company identification number is required.";
                if (!Regex.IsMatch(companyID, @"^\d{8}$"))
                    return "Company identification number must contain exactly 8 digits.";
            }
            return string.Empty;
        }

        public string ValidateCompanyName(object value)
        {
            if (value is string companyName)
            {
                if (string.IsNullOrEmpty(companyName)) return "Company name is required.";
            }
            return string.Empty;
        }
    }
}
