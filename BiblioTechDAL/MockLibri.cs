using BiblioTechBL.Entities;
using BiblioTechBL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechDAL
{
    public class MockLibri : ICRUDLibro
    {
        List<Libro> catalogo = new List<Libro>();
        public void Create(Libro nuovo)
        {
            catalogo.Add(nuovo);
        }

        public void DeleteByID(int id)
        {
            foreach (Libro libro in catalogo)
            {
                if (libro.Id == id)
                {
                    catalogo.Remove(libro);
                }
            }
        }

        public Libro GetById(int id)
        {
            foreach (Libro libro in catalogo)
            {
                if (libro.Id == id)
                {
                    return libro;
                }
            }
            return null;
        }
        public IEnumerable<Libro> Fetch(Func<Libro, bool> filter = null)
        {
            if (filter != null)
                return catalogo.Where(filter);

            return catalogo;
        }

    }
}
