namespace MEXA_SE.Domain.Commands.ExercicioCommands
{
    public class CreateExercicioCommand
    {
        public CreateExercicioCommand(string dsExercicio, int treinoId)
        {
            this.DsExercicio = dsExercicio;
            this.TreinoId = treinoId;
        }

        public string DsExercicio { get; set; }
        public int TreinoId { get; set; }

    }
}
