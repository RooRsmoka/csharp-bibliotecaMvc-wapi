using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_bibliotecaMvc.Models
{
    [Table("Autori")]
    public class Autore
    {
        [Key]
        public int AutoreID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ICollection<Libro>? Libri { get; set; }
    }
}
