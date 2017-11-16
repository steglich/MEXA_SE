using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEXA_SE.Domain.Commands.ExercicioCommands
{
    public class UpdateExercicioCommand
    {
        public UpdateExercicioCommand(int exercicioId, string dsExercicio)
        {
            this.ExercicioId = exercicioId;
            this.DsExercicio = dsExercicio;
        }

        public int ExercicioId { get; set; }
        public string DsExercicio { get; set; }

    }
}
