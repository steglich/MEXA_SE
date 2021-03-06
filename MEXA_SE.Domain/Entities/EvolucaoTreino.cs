﻿using MEXA_SE.Domain.Scopes;
using System;

namespace MEXA_SE.Domain.Entities
{
    public class EvolucaoTreino
    {
        public EvolucaoTreino()
        {

        }
        public EvolucaoTreino(int repeticao, int carga, int exercicioId)
        {
            this.Repeticao = repeticao;
            this.Carga = carga;
            this.AumetoTreino = DateTime.Now.Date;
            this.ExercicioId = exercicioId;
        }

        public int EvolucaoTreinoId { get; set; }

        public int Repeticao { get; private set; }
        public int Carga { get; private set; }
        public DateTime AumetoTreino { get; private set; }

        public int ExercicioId { get; set; }
        public virtual Exercicio Exercicio { get; set; }

        public void CreateEvolucaoTreino()
        {
            this.CreateEvolucaoTreinoScopIsValid();
        }
        public void UpdateEvolucaoTreino(int repeticao, int carga)
        {
            if (!this.UpdateEvolucaoTreinoScopIsValid(repeticao, carga))
                return;

            this.Repeticao = repeticao;
            this.Carga = carga;
            //this.AumetoTreino = aumentoTreino;
        }
    }
}
