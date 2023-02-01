using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechBL.Entities
{
    public class Prestito
    {

        public int Id { get; private set; }
        public DateOnly DataScadenza { get; private set; }
        public DateOnly DaraInizio { get; private set; }

    }
}
