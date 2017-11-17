namespace MEXA_SE.Domain.Commands.UsuarioCommands
{
    public class RegisterUsuarioCommand
    {
        public RegisterUsuarioCommand(string nome, string email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
