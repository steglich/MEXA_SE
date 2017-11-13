using MEXA_SE.Domain.Commands.AvaiacaoCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IAvaliacaoApplicationService
    {
        List<Avaliacao> Get();
        Avaliacao GetOne(int usuarioId, int fichaId);
        void Create(CreateAvaliacaoCommand command);
        void Update(UpdateAvaliacaoCommand command);
    }
}
