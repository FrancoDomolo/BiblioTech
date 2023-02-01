using BiblioTechBL.Entities;
using BiblioTechBL.Interface;
using System.Net.Sockets;

namespace BiblioTechDAL
{
    public class MockIscritti : ICRUDIscritto
    {
        List<Iscritto> iscritti = new List<Iscritto>();
        public void Create(Iscritto nuovo)
        {
            iscritti.Add(nuovo);
        }

        public void DeleteByID(int id)
        {
            foreach (Iscritto item in iscritti)
            {
                if (item.Id == id)
                {
                    iscritti.Remove(item);
                }
            }
        }

        public Iscritto GetById(int id)
        {
            foreach (Iscritto item in iscritti)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public IEnumerable<Iscritto> Fetch(Func<Iscritto, bool> filter = null)
        {
            if (filter != null)
                return iscritti.Where(filter);

            return iscritti;
        }

    }
}