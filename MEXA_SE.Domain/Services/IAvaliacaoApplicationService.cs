using MEXA_SE.Domain.Commands.AvaiacaoCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IAvaliacaoApplicationService
    {
        List<Avaliacao> GetAll();
        Avaliacao GetOne(string email);
        Avaliacao Create(CreateAvaliacaoCommand command);
        Avaliacao Update(UpdateAvaliacaoCommand command);
    }
}
