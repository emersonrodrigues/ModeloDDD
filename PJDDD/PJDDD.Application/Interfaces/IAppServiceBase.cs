using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJDDD.Application.Interfaces
{
    public interface IAppServiceBase <Tentity> where Tentity : class
    {
        void Add(Tentity obj);
        Tentity GetById(int id);
        IEnumerable<Tentity> GetAll();
        void Update(Tentity obj);
        void Remove(Tentity obj);
        void Dispose();
    }
}
