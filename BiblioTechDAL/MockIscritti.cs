using BiblioTechBL.Entities;
using BiblioTechBL.Interface;

namespace BiblioTechDAL
{
    public class MockIscritti : ICRUDIscritto
    {
        public void Create(Iscritto nuovo)
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public Iscritto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Iscritto aggiornato)
        {
            throw new NotImplementedException();
        }
    }
}