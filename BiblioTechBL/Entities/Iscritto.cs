using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechBL.Entities
{
    public class Iscritto
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public int Id { get; private set; }

        public Iscritto(string nome, string cognome, int id) 
        {
            Nome= nome;
            Cognome= cognome;
            Id= id;
        }

    }
}
