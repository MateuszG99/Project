using System.ComponentModel.DataAnnotations;

namespace Project_CarRental.Models
{
    public class CarModel
    {
        public int CarModelId { get; set; }

        [Required(ErrorMessage = "Musisz podać markę!")]
        [MaxLength(50, ErrorMessage = "Maksymalna długość to 50 znaków!")]
        [MinLength(2, ErrorMessage = "Minimalna długość to 2 znaki!")]
        [Display(Name = "Marka")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Musisz podać model pojazdu!")]
        [MaxLength(50, ErrorMessage = "Maksymalna długość to 50 znaków!")]
        [MinLength(2, ErrorMessage = "Minimalna długość to 2 znaki!")]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Musisz podać rodzaj paliwa")]
        [MaxLength(20, ErrorMessage = "Maksymalna długość to 20 znaków!")]
        [MinLength(3, ErrorMessage = "Minimalna długość to 3 znaki!")]
        [Display(Name = "Paliwo")]
        public string FuelType { get; set; }
    }
}
