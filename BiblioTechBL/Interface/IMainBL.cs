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
        void AddIscritto(Iscritto nuovoIscritto);
        void RemoveIscrittoById(int id);


        Libro GetLibroById(int id);
        void AddLibro(Libro nuovoLibro);
        void RemoveLibroById(int id);
        List<Libro> GetDisponibili();
        List<Libro> GetInPrestito();



        Prestito GetPrestitoById(int id);
        void AddPrestito(Prestito nuovoPrestito);
        void RemovePrestitoById(int id);
        List<Iscritto> GetRitardatari();
        List<Iscritto> GetInattvi();


    }
}
