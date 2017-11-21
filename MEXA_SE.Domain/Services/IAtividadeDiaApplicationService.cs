using MEXA_SE.Domain.Commands.AtividadeDiacommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IAtividadeDiaApplicationService
    {
        List<AtividadeDia> GetAll();
        List<AtividadeDia>GetOne(string email);
        AtividadeDia Create(CreateAtividadeDiaCommand command);
        //AtividadeDia Update(UpdateAtividadeDiaCommand command);
    }
}
