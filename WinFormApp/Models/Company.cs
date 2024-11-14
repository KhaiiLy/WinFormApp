using System.ComponentModel.DataAnnotations;

namespace WinFormApp.Models
{
    public class Company
    {
        // Datovy model firmy - nastaveni data anotaci, povoleneho formatu hodnot

        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Company Identifacation Number is required")]
        [StringLength(8)]
        public string CompanyID { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Company Name is required")]
        public string CompanyName { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone number is required")]
        [RegularExpression(@"\+\d{1,3} \d{3} \d{3} \d{3}", ErrorMessage = "Invalid Phone Number format")]
        public string PhoneNumber { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        [EmailAddress]
        [RegularExpression(@"\w+([-._]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Invalid Email Address format")]
        public string Email { get; set; } = null!;
    }
}
