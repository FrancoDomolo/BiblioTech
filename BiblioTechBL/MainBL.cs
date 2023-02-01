using BiblioTechBL.Entities;
using BiblioTechBL.Interface;

namespace BiblioTechBL
{
    public class MainBL : IMainBL
    {
        private ICRUDIscritto _mockIscritti;
        private ICRUDLibro _mockLibri;
        private ICRUDPrestito _mockPrestiti;

        public void AddIscritto(Iscritto nuovoIscritto)
        {
            _mockIscritti.Create(nuovoIscritto);
        }

        public void AddLibro(Libro nuovoLibro)
        {
            throw new NotImplementedException();
        }

        public void AddPrestito(Prestito nuovoPrestito)
        {
            _mockPrestiti.Create(nuovoPrestito);
        }

        public List<Libro> GetDisponibili()
        {
            throw new NotImplementedException();
        }

        public List<Iscritto> GetInattvi()
        {
            throw new NotImplementedException();
        }

        public List<Libro> GetInPrestito()
        {
            throw new NotImplementedException();
        }

        public Iscritto GetIscrittoById(int id)
        {
            return _mockIscritti.GetById(id);
        }

        public Libro GetLibroById(int id)
        {
            throw new NotImplementedException();
        }

        public Prestito GetPrestitoById(int id)
        {
            return _mockPrestiti.GetById(id);
        }

        public List<Iscritto> GetRitardatari()
        {
            throw new NotImplementedException();
        }

        public void RemoveIscrittoById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveLibroById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemovePrestitoById(int id)
        {
            _mockPrestiti.DeleteByID(id);
        }
    }
}