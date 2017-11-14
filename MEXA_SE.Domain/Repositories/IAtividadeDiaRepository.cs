using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IAtividadeDiaRepository
    {
        List<AtividadeDia> GetAll(string email);
        //AtividadeDia GetOne(int id, string email);
        void Create(AtividadeDia atividadeDia);
        void Update(AtividadeDia atividadeDia);
    }
}
