using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEXA_SE.Domain.Commands.ExercicioCommands
{
    public class UpdateExercicioCommand
    {
        public UpdateExercicioCommand(int exercicioId, string dsExercicio, int treinoId)
        {
            this.ExercicioId = exercicioId;
            this.DsExercicio = dsExercicio;
            this.TreinoId = treinoId;
        }

        public int ExercicioId { get; set; }
        public string DsExercicio { get; set; }
        public int TreinoId { get; set; }

    }
}
