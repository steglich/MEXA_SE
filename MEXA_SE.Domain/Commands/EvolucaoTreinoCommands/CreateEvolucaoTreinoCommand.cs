using System;

namespace MEXA_SE.Domain.Commands.EvolucaoTreinoCommands
{
    public class CreateEvolucaoTreinoCommand
    {
        public CreateEvolucaoTreinoCommand(int repeticao, int carga, DateTime aumentoTreino, int exercicioId)
        {
            this.Repeticao = repeticao;
            this.Carga = carga;
            this.AumetoTreino = aumentoTreino;
            this.ExercicioId = exercicioId;
        }

        public int Repeticao { get; private set; }
        public int Carga { get; private set; }
        public DateTime AumetoTreino { get; private set; }

        public int ExercicioId { get; set; }
        
    }
}
