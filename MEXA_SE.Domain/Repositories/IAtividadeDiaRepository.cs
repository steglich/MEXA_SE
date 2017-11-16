using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Repositories
{
    public interface IAtividadeDiaRepository
    {
        List<AtividadeDia> GetAll();
        AtividadeDia GetOne(string email);
        void Create(AtividadeDia atividadeDia);
        void Update(AtividadeDia atividadeDia);
    }
}
