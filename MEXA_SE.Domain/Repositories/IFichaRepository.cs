using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IFichaRepository
    {
        List<Ficha> GetAll();
        Ficha GetId(int fichaId);
        Ficha GetOne(int fichaId, string email);
        void Create(Ficha ficha);
        void Update(Ficha ficha);
    }
}
