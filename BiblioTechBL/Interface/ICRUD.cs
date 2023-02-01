using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechBL.Interface
{
    public interface ICRUD<T>
    {
        T GetById(int id);
        void Create(T nuovo);
        void Update(T aggiornato);
        void DeleteByID(int id);

    }
}
