using BiblioTechBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechBL.Interface
{
    public interface IMainBL
    {
        Iscritto GetIscrittoById(int id);
        Libro GetLibroById(int id);
        Prestito GetPrestitoById(int id);

        void AddIscritto(Iscritto nuovoIscritto);
        void AddLibro(Libro nuovoLibro);
        void AddPrestito(Prestito nuovoPrestito);

        void RemoveIscrittoById(int id);
        void RemoveLibroById(int id);
        void RemovePrestitoById(int id);

        void UpdateIscritto(Iscritto update);


    }
}
