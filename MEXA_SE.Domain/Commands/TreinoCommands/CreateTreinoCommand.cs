namespace MEXA_SE.Domain.Commands.TreinoCommands
{
    public class CreateTreinoCommand
    {
        public CreateTreinoCommand(string dsTreino, int usuarioTreinoId)
        {
            this.DsTreino = dsTreino;
            this.UsuarioTreinoId = usuarioTreinoId;
        }

        public string DsTreino { get; set; }

        public int UsuarioTreinoId { get; set; }
    }
}
