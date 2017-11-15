﻿using System;

namespace MEXA_SE.Domain.Commands.EvolucaoTreinoCommands
{
    public class UpdateEvolucaoTreinoCommand
    {
        public UpdateEvolucaoTreinoCommand(int evolucaoTreinoId, int repeticao, int carga, DateTime aumentoTreino, int exercicioId)
        {
            this.EvolucaoTreinoId = evolucaoTreinoId;
            this.Repeticao = repeticao;
            this.Carga = carga;
            this.AumetoTreino = aumentoTreino;
            this.ExericioId = ExericioId;
        }

        public int EvolucaoTreinoId { get; set; }

        public int Repeticao { get; private set; }
        public int Carga { get; private set; }
        public DateTime AumetoTreino { get; private set; }

        public int ExericioId { get; set; }
    }
}
