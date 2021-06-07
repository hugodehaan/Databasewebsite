using System.ComponentModel.DataAnnotations;

namespace SendAndStore.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Voornaam is verplicht in te vullen")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Achternaam is verplicht in te vullen")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is verplicht in te vullen")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
    }
}