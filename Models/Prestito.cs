using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_bibliotecaMvc.Models
{
    [Table("Prestiti")]
    public class Prestito
    {
        [Key]
        public int PrestitoID { get; set; }
        public int LibroID { get; set; }
        public int UtenteID { get; set; }
        public DateTime DataPrestito { get; set; }
        public Utente Utente { get; set; }
        public Libro Libro { get; set; }
    }
}
