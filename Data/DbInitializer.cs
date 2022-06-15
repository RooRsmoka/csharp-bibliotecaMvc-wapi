using csharp_bibliotecaMvc.Models;

namespace csharp_bibliotecaMvc.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            if (context.Utenti.Any())
            {
                return;
            }

            var utenti = new Utente[]
            {
                new Utente{FirstName = "Mario", LastName = "Rossi", Email = "mario.rossi@gmail.com"},
                new Utente{FirstName = "Andrea", LastName = "Marino", Email = "andrea.marino@outlook.it"},
                new Utente{FirstName = "Paolo", LastName = "Valoti", Email = "paolo.valoti@virgilio.it"},
                new Utente{FirstName = "Alice", LastName = "Licata", Email = "alice.licata@yahoo.it"},
                new Utente{FirstName = "Francesca", LastName = "Verdi", Email = "francesca.verdi@gmail.it"},
                new Utente{FirstName = "Gianluca", LastName = "Amato", Email = "gianluca.amato@yahoo.it"},
                new Utente{FirstName = "Simona", LastName = "Bianchi", Email = "simona.bianchi@gmail.com"},
                new Utente{FirstName = "Matteo", LastName = "Ferri", Email = "matteo.ferri@gmail.it"},
                new Utente{FirstName = "Giovanni", LastName = "Cortese", Email = "giovanni.cortese@outlook.it"},
                new Utente{FirstName = "Alessandro", LastName = "Oliva", Email = "alessandro.oliva@virgilio.it"}
            };

            foreach (Utente u in utenti)
            {
                context.Utenti.Add(u);
            }
            context.SaveChanges();

            var autori = new Autore[]
            {
                new Autore{FirstName = "Alessandro", LastName = "Manzoni"},
                new Autore{FirstName = "Dmitrij", LastName = "Gluchovskij"},
                new Autore{FirstName = "Stephen", LastName = "King"},
                new Autore{FirstName = "Frank", LastName = "Herbert"},
                new Autore{FirstName = "J.R.R", LastName = "Tolkien"},
                new Autore{FirstName = "Antoine", LastName = "de Saint-Exupéry"},
            };

            foreach (Autore a in autori)
            {
                context.Autori.Add(a);
            }
            context.SaveChanges();

            var Manzoni = context.Autori.Where(item => item.LastName == "Manzoni").First();
            var Gluchovskij = context.Autori.Where(item => item.LastName == "Gluchovskij").First();
            var King = context.Autori.Where(item => item.LastName == "King").First();
            var Herbert = context.Autori.Where(item => item.LastName == "Herbert").First();
            var Tolkien = context.Autori.Where(item => item.LastName == "Tolkien").First();
            var deSaintExupéry = context.Autori.Where(item => item.LastName == "de Saint-Exupéry").First();

            var libri = new Libro[]
            {
                new Libro{Titolo = "I Promessi Sposi", Scaffale = 001, StatoLibro = Stato.Disponibile, Autori = new List<Autore>{Manzoni}},
                new Libro{Titolo = "Metro 2033", Scaffale = 002, StatoLibro = Stato.Disponibile, Autori = new List<Autore>{Gluchovskij}},
                new Libro{Titolo = "It", Scaffale = 003, StatoLibro = Stato.Disponibile, Autori = new List<Autore>{King}},
                new Libro{Titolo = "Dune", Scaffale = 004, StatoLibro = Stato.Disponibile, Autori = new List<Autore>{Herbert}},
                new Libro{Titolo = "Il Signore degli Anelli", Scaffale = 005, StatoLibro = Stato.Disponibile, Autori = new List<Autore>{Tolkien}},
                new Libro{Titolo = "Il Piccolo Principe", Scaffale = 006, StatoLibro = Stato.Disponibile, Autori = new List<Autore>{deSaintExupéry}}
            };

            foreach (Libro l in libri)
            {
                context.Libri.Add(l);
            }
            context.SaveChanges();

            var prestiti = new Prestito[]
            {
                new Prestito{LibroID = 1, UtenteID = 1, DataPrestito = DateTime.Parse("2021-06-13")},
                new Prestito{LibroID = 6, UtenteID = 2, DataPrestito = DateTime.Parse("2021-08-22")},
                new Prestito{LibroID = 4, UtenteID = 3, DataPrestito = DateTime.Parse("2021-05-02")},
                new Prestito{LibroID = 5, UtenteID = 4, DataPrestito = DateTime.Parse("2021-01-10")},
                new Prestito{LibroID = 2, UtenteID = 5, DataPrestito = DateTime.Parse("2021-06-28")},
                new Prestito{LibroID = 3, UtenteID = 6, DataPrestito = DateTime.Parse("2021-07-19")},
                new Prestito{LibroID = 6, UtenteID = 7, DataPrestito = DateTime.Parse("2022-03-06")},
                new Prestito{LibroID = 2, UtenteID = 8, DataPrestito = DateTime.Parse("2022-10-14")},
                new Prestito{LibroID = 1, UtenteID = 9, DataPrestito = DateTime.Parse("2022-12-05")},
                new Prestito{LibroID = 5, UtenteID = 10, DataPrestito = DateTime.Parse("2022-09-16")}
            };

            foreach (Prestito p in prestiti)
            {
                context.Prestiti.Add(p);
            }
            context.SaveChanges();
        }
    }
}
