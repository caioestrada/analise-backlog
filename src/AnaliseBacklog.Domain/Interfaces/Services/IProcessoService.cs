namespace AnaliseBacklog.Domain.Interfaces.Services
{
    public interface IProcessoService
    {
        string UnificarDados(string caminhoDaPlanilhaBacklog, string caminhoDaPlanilhaTracking, string caminhoDaPlanilhaBase);
    }
}
