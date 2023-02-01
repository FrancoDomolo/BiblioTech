using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechBL.Entities
{
    public class Libro
    {
      

        public int Id { get; private set; }
       
        public string Nome { get; private set; }
       
        public string Autore { get; private set; }
       
        public int AnnoPubblicazione { get; private set; }
        
        public string Genere { get; private set; }

        public bool IsAvailable { get; private set; }


        public Libro(int id, string nome, string autore, int annoPubblicazione, string genere, bool isAvailable)
        {
            Id = id;
            Nome = nome;
            Autore = autore;
            AnnoPubblicazione = annoPubblicazione;
            Genere = genere;
            IsAvailable = isAvailable;
        }



    }
}
