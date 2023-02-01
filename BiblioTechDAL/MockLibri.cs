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
        public void Create(Libro nuovo)
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public Libro GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Libro aggiornato)
        {
            throw new NotImplementedException();
        }
    }
}
