using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_bibliotecaMvc.Models
{
    public enum Stato
    {
        Disponibile, Prestito
    }

    [Table("Libri")]
    public class Libro
    {
        [Key]
        public int LibroID { get; set; }
        public string Titolo { get; set; }
        public int Scaffale { get; set; }
        public Stato StatoLibro { get; set; }
        public ICollection<Autore>? Autori { get; set; }
        public ICollection<Prestito>? Prestito { get; set; } 
    }
}
