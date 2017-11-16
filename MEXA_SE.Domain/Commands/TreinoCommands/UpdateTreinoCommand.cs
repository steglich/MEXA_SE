namespace MEXA_SE.Domain.Commands.TreinoCommands
{
    public class UpdateTreinoCommand
    {
        public UpdateTreinoCommand(int treinoId, string dsTreino)
        {
            this.TreinoId = treinoId;
            this.DsTreino = dsTreino;
            //this.UsuarioTreinoId = UsuarioTreinoId;
        }

        public int TreinoId { get; set; }
        public string DsTreino { get; set; }

        //public int UsuarioTreinoId { get; set; }
    }
}
