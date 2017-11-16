using MEXA_SE.Domain.Scopes;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Entities
{
    public class Exercicio
    {
        public Exercicio()
        {

        }
        public Exercicio(string dsExercicio, int treinoId)
        {
            this.DsExercicio = dsExercicio;
            this.TreinoId = treinoId;

            this.EvolucaoTreino = new List<EvolucaoTreino>();
        }

        public int ExercicioId { get; set; }
        public string DsExercicio { get; set; }

        public int TreinoId { get; set; }
        public virtual Treino Treino { get; set; }

        public virtual ICollection<EvolucaoTreino> EvolucaoTreino { get; set; }

        public void CreateExercicio()
        {
            this.CreateExrecicioScopIsValid();
        }
        public void UpdateExercicio(string dsExercicio)
        {
            if (!this.UpdateExrecicioScopIsValid(dsExercicio))
                return;

            this.DsExercicio = dsExercicio;
        }
    }
}