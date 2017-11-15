namespace MEXA_SE.Domain.Commands.UsuarioCommands
{
    public class UpdateUsuarioCommand
    {
        public UpdateUsuarioCommand(int id, string nome, string email, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            //this.IsAdmin = isAdmin;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        //public bool IsAdmin { get; set; }
    }
}
