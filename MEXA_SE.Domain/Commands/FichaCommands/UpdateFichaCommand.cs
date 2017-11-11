namespace MEXA_SE.Domain.Commands.FichaCommands
{
    public class UpdateFichaCommand
    {
        public UpdateFichaCommand(int fichaId, float peso, float altura, float gordura, float peito, float cintura, float quadril, float anteBracoDireito,
            float anteBracoEsquerdo, float bracoDireito, float bracoEsquerdo, float coxaDireita, float coxaEsquerda, float pantuDireita, float pantuEsquerda)
        {
            this.FichaId = fichaId;
            this.Peso = peso;
            this.Altura = Altura;
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

        public int FichaId { get; set; }
        public float Peso { get; private set; }
        public float Altura { get; private set; }
        public float Imc
        {
            get { return Imc; }
            private set { Imc = (this.Peso / (this.Altura * 2)); }
        }
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
    }
}
