using MEXA_SE.Domain.Entities;
using MEXA_SE.SharedKernel.Validation;

namespace MEXA_SE.Domain.Scopes
{
    public static class FichaScopes
    {
        public static bool CreateFichaScopIsValid(this Ficha ficha)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(ficha.Peso.ToString(), "O campo peso é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.Peso, 0, "O campo peso tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.Altura.ToString(), "O campo altura é Obrigatória!"),
                AssertionConcern.AssertIsGreaterThan(ficha.Altura, 0, "O campo altura tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.Gordura.ToString(), "O campo gordura é Obrigatória!"),
                AssertionConcern.AssertIsGreaterThan(ficha.Gordura, 0, "O campo gordura tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.Peito.ToString(), "O campo peito é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.Peito, 0, "O campo peito tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.Cintura.ToString(), "O campo cintura é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.Cintura, 0, "O campo cintura tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.Quadril.ToString(), "O campo quadril é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.Quadril, 0, "O campo quadril tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.AnteBracoDireito.ToString(), "O campo antebraço direito é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.AnteBracoDireito, 0, "O campo antebraço direito tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.AnteBracoEsquerdo.ToString(), "O campo antebraço esquerdo é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.AnteBracoEsquerdo, 0, "O campo antebraço esquerdo tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.BracoDireito.ToString(), "O campo braço direito é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.BracoDireito, 0, "O campo braço direito tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.BracoEsquerdo.ToString(), "O campo braço esquerdo é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.BracoEsquerdo, 0, "O campo braço esquerdo tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.CoxaDireita.ToString(), "O campo coxa diretia é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.CoxaDireita, 0, "O campo coxa direita tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.CoxaEsquerda.ToString(), "O campo coxa esuqerda é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.CoxaEsquerda, 0, "O campo coxa esquerda tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.PantuDireita.ToString(), "O campo panturilha direita é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.PantuDireita, 0, "O campo panturilha diretia tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(ficha.PantuEsquerda.ToString(), "O campo panturilha esquerda é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(ficha.PantuEsquerda, 0, "O campo panturilha esquerda tem que ser maior que zero!")
                );
        }

        public static bool UpdateFichaScopIsValid(this Ficha ficha, float peso, float altura, float gordura, float peito,
            float cintura, float quadril, float anteBracoDireito, float anteBracoEsquerdo,
            float bracoDireito, float bracoEsquerdo, float coxaDireita, float coxaEsquerda,
            float pantuDireita, float pantuEsquerda)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(peso.ToString(), "O campo peso é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(peso, 0, "O campo peso tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(altura.ToString(), "O campo altura é Obrigatória!"),
                AssertionConcern.AssertIsGreaterThan(altura, 0, "O campo altura tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(gordura.ToString(), "O campo gordura é Obrigatória!"),
                AssertionConcern.AssertIsGreaterThan(gordura, 0, "O campo gordura tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(peito.ToString(), "O campo peito é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(peito, 0, "O campo peito tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(cintura.ToString(), "O campo cintura é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(cintura, 0, "O campo cintura tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(quadril.ToString(), "O campo quadril é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(quadril, 0, "O campo quadril tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(anteBracoDireito.ToString(), "O campo antebraço direito é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(anteBracoDireito, 0, "O campo antebraço direito tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(anteBracoEsquerdo.ToString(), "O campo antebraço esquerdo é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(anteBracoEsquerdo, 0, "O campo antebraço esquerdo tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(bracoDireito.ToString(), "O campo braço direito é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(bracoDireito, 0, "O campo braço direito tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(bracoEsquerdo.ToString(), "O campo braço esquerdo é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(bracoEsquerdo, 0, "O campo braço esquerdo tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(coxaDireita.ToString(), "O campo coxa diretia é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(coxaDireita, 0, "O campo coxa direita tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(coxaEsquerda.ToString(), "O campo coxa esuqerda é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(coxaEsquerda, 0, "O campo coxa esquerda tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(pantuDireita.ToString(), "O campo panturilha direita é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(pantuDireita, 0, "O campo panturilha diretia tem que ser maior que zero!"),

                AssertionConcern.AssertNotEmpty(pantuEsquerda.ToString(), "O campo panturilha esquerda é Obrigatório!"),
                AssertionConcern.AssertIsGreaterThan(pantuEsquerda, 0, "O campo panturilha esquerda tem que ser maior que zero!")
                );
        }
    }
}
