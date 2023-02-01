using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechBL.Entities
{
    public class Prestito
    {
        public Prestito(int id, DateOnly dataScadenza, DateOnly dartInizio, Iscritto utente, Libro book)
        {
            Id = id;
            DataScadenza = dataScadenza;
            DataInizio = dartInizio;
            Utente = utente;
            Book = book;
        }

        public int Id { get; private set; }
        public DateOnly DataScadenza { get; private set; }
        public DateOnly DataInizio { get; private set; }

        public Iscritto Utente { get; private set; }
        public Libro Book { get; private set; }

        
    }
}
