using System.ComponentModel.DataAnnotations;

namespace Project_CarRental.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Musisz podać imię!")]
        [MaxLength(50, ErrorMessage = "Maksymalna długość to 50 znaków!")]
        [MinLength(2, ErrorMessage = "Minimalna długość to 2 znaki!")]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwisko!")]
        [MaxLength(50, ErrorMessage = "Maksymalna długość to 50 znaków!")]
        [MinLength(2, ErrorMessage = "Minimalna długość to 2 znaki!")]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Musisz podać numer PESEL")]
        [RegularExpression("[0-9]{11}", ErrorMessage = "PESEL może składać się wyłącznie z 11 cyfr!")]
        [Display(Name = "PESEL")]
        public string PESEL { get; set; }

        public override string ToString() => $"{FirstName} {LastName}, PESEL: {PESEL}";
    }
}
