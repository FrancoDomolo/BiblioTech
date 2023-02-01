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
            _mockLibri.Create(nuovoLibro);
        }

        public void AddPrestito(Prestito nuovoPrestito)
        {
            _mockPrestiti.Create(nuovoPrestito);
        }

        public IEnumerable<Libro> GetDisponibili()
        {
            return _mockLibri.Fetch(x => x.IsAvailable == true);
        }

        public List<Iscritto> GetInattivi()
        {
            IEnumerable<Prestito> prestitiInattivi = _mockPrestiti.Fetch(x => (DateTime.Now.Month - x.DataInizio.Month) > 2);
            List<Iscritto> inattivi = new List<Iscritto>();
            foreach (Prestito prestito in prestitiInattivi)
            {
                inattivi.Add(prestito.Utente);
            }
            return inattivi;
        }

        public IEnumerable<Libro> GetInPrestito()
        {
            return _mockLibri.Fetch(x => x.IsAvailable == false);
        }

        public Iscritto GetIscrittoById(int id)
        {
            return _mockIscritti.GetById(id);
        }

        public Libro GetLibroById(int id)
        {
            return _mockLibri.GetById(id);
        }

        public Prestito GetPrestitoById(int id)
        {
            return _mockPrestiti.GetById(id);
        }

        public List<Iscritto> GetRitardatari()
        {
            IEnumerable<Prestito> prestitiScaduti = _mockPrestiti.Fetch(x => DateOnly.FromDateTime(DateTime.Now) > x.DataScadenza);
            List<Iscritto> ritardatari = new List<Iscritto>();
            foreach (Prestito prestito in prestitiScaduti)
            {
                ritardatari.Add(prestito.Utente);
            }
            return ritardatari;

        }

        public void RemoveIscrittoById(int id)
        {
            _mockIscritti.DeleteByID(id);
        }

        public void RemoveLibroById(int id)
        {
           _mockLibri.DeleteByID(id);
        }

        public void RemovePrestitoById(int id)
        {
            _mockPrestiti.DeleteByID(id);
        }
    }
}