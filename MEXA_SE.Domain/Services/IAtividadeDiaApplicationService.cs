using MEXA_SE.Domain.Commands.AtividadeDiacommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IAtividadeDiaApplicationService
    {
        List<AtividadeDia> Get();
        AtividadeDia GetOne(int id, string email);
        void Create(CreateAtividadeDiaCommand command);
        void Update(UpdateAtividadeDiaCommand command);
    }
}
