using MEXA_SE.Domain.Commands.FichaCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IFichaApplicationService
    {
        List<Ficha> GetAll();
        Ficha GetOne(string email);
        Ficha Create(CreateFichaCommand command);
        Ficha Update(UpdateFichaCommand command);
    }
}
