namespace MEXA_SE.Domain.Commands.UsuarioCommands
{
    public class RegisterUsuarioCommand
    {
        public RegisterUsuarioCommand(string nome, string email, string senha, bool isAdmin)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.IsAdmin = isAdmin;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool IsAdmin { get; set; }
    }
}
