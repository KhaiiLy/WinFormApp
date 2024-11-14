using System.ComponentModel.DataAnnotations;

namespace WinFormApp.Models
{
    public class Person
    {
        // Datovy model Osoby - nastaveni data anotaci, povolenych formatu hodnot
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is required..")]
        [RegularExpression("[a-zA-Zá-žÁ-Ž0-9 ]{2,30}")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "First Name must be at least 2 characters")]
        public string FirstName { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is required")]
        [RegularExpression("[a-zA-Zá-žÁ-Ž0-9 ]{2,30}")]
        public string LastName { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Birthdate is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; } = null;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone number is required")]
        [RegularExpression(@"\+\d{1,3} \d{3} \d{3} \d{3}", ErrorMessage = "Invalid Phone Number format")]
        public string PhoneNumber { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        [EmailAddress]
        [RegularExpression(@"\w+([-._]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Invalid Email Address format")]
        public string Email { get; set; } = null!;

    }
}
