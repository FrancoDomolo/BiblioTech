using BiblioTechBL.Entities;
using BiblioTechBL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechDAL
{
    public class MockPrestiti : ICRUDPrestito
    {
        public void Create(Prestito nuovo)
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public Prestito GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Prestito aggiornato)
        {
            throw new NotImplementedException();
        }
    }
}
