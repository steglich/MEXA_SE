using MEXA_SE.Domain.Scopes;
using MEXA_SE.SharedKernel.Helpers;
using System.Collections.Generic;

namespace MEXA_SE.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        {

        }
        public Usuario(string nome, string email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = StringHelper.Encrypt(senha);
            this.IsAdmin = true;

            this.AtividadeDia = new List<AtividadeDia>();
            this.Avaliacao = new List<Avaliacao>();
            this.UsuarioTreino = new List<UsuarioTreino>();
        }
        
        public int UsuarioId { get; set; }        
        public string Nome { get; private set; }        
        public string Email { get; private set; }        
        public string Senha { get; private set; }
        public bool IsAdmin { get; private set; }

        public virtual ICollection<AtividadeDia> AtividadeDia { get; set; }
        public virtual ICollection<Avaliacao> Avaliacao { get; set; }
        public virtual ICollection<UsuarioTreino> UsuarioTreino { get; set; }

        public void RegisterUsuario() => this.CreateUsuarioScopIsValid();
        public void UpdateUsuario(string nome, string email, string senha)
        {
            if (!this.UpdateUsuarioScopIsValid(nome, email, senha))
                return;

            this.Nome = nome;
            this.Email = email;
            this.Senha = StringHelper.Encrypt(senha); // encriptar senha
        }

        public void Authenticate(string email, string senha) => this.AuthenticateUsuarioScopIsValid(email, senha);

        public void GrantAdmin() => this.IsAdmin = true;

        public void RevokeAdmin() => this.IsAdmin = false;

        public void AddTreino(UsuarioTreino usuarioTreino, int usuarioId, string dsTreino)
        {
            //this.UsuarioTreino = usuarioTreino(new DateTime(2017, 10, 12));
        }
    }
}
