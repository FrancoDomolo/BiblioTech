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
        private List<Prestito> prestitoList = new List<Prestito>();
        public void Create(Prestito nuovo)
        {
            prestitoList.Add(nuovo);
        }

        public void DeleteByID(int id)
        {
            foreach (Prestito item in prestitoList)
            {
                if (item.Id == id)
                {
                    prestitoList.Remove(item);
                }
            }
        }

        public Prestito GetById(int id)
        {
            foreach (Prestito item in prestitoList)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public IEnumerable<Prestito> Fetch(Func<Prestito, bool> filter = null)
        {
            if (filter != null)
                return prestitoList.Where(filter);

            return prestitoList;
        }
    }
}
