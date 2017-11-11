namespace MEXA_SE.Domain.Commands.TreinoCommands
{
    public class CreateTreinoCommand
    {
        public CreateTreinoCommand(string dsTreino)
        {
            this.DsTreino = dsTreino;
        }

        public string DsTreino { get; set; }
    }
}
