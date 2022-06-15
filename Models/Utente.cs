using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_bibliotecaMvc.Models
{
    [Table("Utenti")]
    public class Utente
    {
        [Key]
        public int UtenteID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Prestito> Prestiti { get; set; }
    }
}
