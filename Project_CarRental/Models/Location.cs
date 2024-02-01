using System.ComponentModel.DataAnnotations;

namespace Project_CarRental.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        [Required(ErrorMessage = "Musisz podać miasto!")]
        [MaxLength(50, ErrorMessage = "Maksymalna długość to 50 znaków!")]
        [MinLength(2, ErrorMessage = "Minimalna długość to 2 znaki!")]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Required(ErrorMessage = "Musisz podać adres!")]
        [MaxLength(50, ErrorMessage = "Maksymalna długość to 50 znaków!")]
        [MinLength(2, ErrorMessage = "Minimalna długość to 2 znaki!")]
        [Display(Name = "Adres")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Musisz podać numer telefonu")]
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{3}", ErrorMessage = "Numer telefonu musi być podany w formacie: '000-000-000'")]
        [Display(Name = "Numer telefonu")]
        public string TelephoneNumber { get; set; }
    }
}
