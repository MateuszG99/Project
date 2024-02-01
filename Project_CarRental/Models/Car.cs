using System.ComponentModel.DataAnnotations;

namespace Project_CarRental.Models
{
    public class Car
    {
        public int CarId { get; set; }

        [Required(ErrorMessage = "Numer rejestracyjny wymagany!")]
        [StringLength(8, MinimumLength = 7, ErrorMessage = "Numer rejestracyjny musi mieć długość od 7 do 8 znaków!")]
        [Display(Name = "Numer rejestracyjny")]
        public string? RegisterNumber { get; set; }

        [Required(ErrorMessage = "Musisz podać model samochodu!")]
        [Display(Name = "Model samochodu")]
        public int CarModelId { get; set; }
        [Display(Name = "Model samochodu")]
        public CarModel? CarModel { get; set; }

        [Display(Name = "Lokalizacja")]
        public int? LocationId { get; set; }
        [Display(Name = "Lokalizacja")]
        public Location? Location { get; set; }

        [Display(Name = "Klient")]
        public int? CustomerId { get; set; }
        [Display(Name = "Klient")]
        public Customer? Customer { get; set; }
    }
}
