using MEXA_SE.Domain.Commands.FichaCommands;
using MEXA_SE.Domain.Entities;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Services
{
    public interface IFichaApplicationService
    {
        List<Ficha> Get();
        List<Ficha> GetUsuario(string email);
        Ficha GetOne(int id);
        void Create(CreateFichaCommand command);
        void Update(UpdateFichaCommand command);
    }
}
