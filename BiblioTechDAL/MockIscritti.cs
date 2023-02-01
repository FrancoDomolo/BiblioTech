using BiblioTechBL.Entities;
using BiblioTechBL.Interface;

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

        public void Update(Iscritto aggiornato)
        {
            throw new NotImplementedException();
        }
    }
}