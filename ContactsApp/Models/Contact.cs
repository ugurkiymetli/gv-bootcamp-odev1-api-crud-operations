using System.ComponentModel.DataAnnotations;
namespace ContactsApp.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter surname"), MaxLength(30)]
        [Display(Name = "Surname")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Profile Picture")]
        [DataType(DataType.ImageUrl)]
        public string ProfilePicture { get; set; }

    }
}
