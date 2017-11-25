using MEXA_SE.Domain.Scopes;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Entities
{
    public class Ficha
    {
        public Ficha()
        {

        }
        public Ficha(float peso, float altura, float gordura, float peito, float cintura, float quadril, float  anteBracoDireito,
            float anteBracoEsquerdo, float bracoDireito, float bracoEsquerdo, float coxaDireita, float coxaEsquerda, float pantuDireita, float pantuEsquerda, int avaliacaoId)
        {
            this.Peso = peso;
            this.Altura = altura;
            this.Imc = (peso / (altura * altura));
            this.Gordura = gordura;
            this.Peito = peito;
            this.Cintura = cintura;
            this.Quadril = quadril;
            this.AnteBracoDireito = anteBracoDireito;
            this.AnteBracoEsquerdo = anteBracoEsquerdo;
            this.BracoDireito = bracoDireito;
            this.BracoEsquerdo = bracoEsquerdo;
            this.CoxaDireita = coxaDireita;
            this.CoxaEsquerda = coxaEsquerda;
            this.PantuDireita = pantuDireita;
            this.PantuEsquerda = pantuEsquerda;

            this.AvaliacaoId = avaliacaoId;

            //this.Avaliacao = new List<Avaliacao>();
        }

        public int FichaId { get; set; }
        public float Peso { get; private set; }
        public float Altura { get; private set; }
        public float Imc { get; private set; }
        public float Gordura { get; private set; }
        public float Peito { get; private set; }
        public float Cintura { get; private set; }
        public float Quadril { get; private set; }
        public float AnteBracoDireito { get; private set; }
        public float AnteBracoEsquerdo { get; private set; }
        public float BracoDireito { get; private set; }
        public float BracoEsquerdo { get; private set; }
        public float CoxaDireita { get; private set; }
        public float CoxaEsquerda { get; private set; }
        public float PantuDireita { get; private set; }
        public float PantuEsquerda { get; private set; }

        public int AvaliacaoId { get; set; }
        public virtual Avaliacao Avaliacao { get; set; }

        //public virtual ICollection<Avaliacao> Avaliacao { get; set; }

        public void CreateFicha()
        {
            this.CreateFichaScopIsValid();
        }
        public void UpdateFicha(float peso, float altura, float gordura, float peito, float cintura, float quadril, float anteBracoDireito,
            float anteBracoEsquerdo, float bracoDireito, float bracoEsquerdo, float coxaDireita, float coxaEsquerda, float pantuDireita, float pantuEsquerda)
        {

            if (!this.UpdateFichaScopIsValid(peso, altura, gordura, peito,
            cintura, quadril, anteBracoDireito, anteBracoEsquerdo,
            bracoDireito, bracoEsquerdo, coxaDireita, coxaEsquerda,
            pantuDireita, pantuEsquerda))
                return;

            this.Peso = peso;
            this.Altura = altura;
            this.Imc = (peso / (altura * altura));
            this.Gordura = gordura;
            this.Peito = peito;
            this.Cintura = cintura;
            this.Quadril = quadril;
            this.AnteBracoDireito = anteBracoDireito;
            this.AnteBracoEsquerdo = anteBracoEsquerdo;
            this.BracoDireito = bracoDireito;
            this.BracoEsquerdo = bracoEsquerdo;
            this.CoxaDireita = coxaDireita;
            this.CoxaEsquerda = coxaEsquerda;
            this.PantuDireita = pantuDireita;
            this.PantuEsquerda = pantuEsquerda;
        }
    }
}
