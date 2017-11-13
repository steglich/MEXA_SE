using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IFichaRepository
    {
        List<Ficha> Get();
        List<Ficha> GetUsuario(string email);
        Ficha GetOne(int id);
        void Create(Ficha ficha);
        void Update(Ficha ficha);
    }
}
