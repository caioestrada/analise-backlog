using AnaliseBacklog.Domain.Entities;
using System.Collections.Generic;

namespace AnaliseBacklog.Domain.Interfaces.Services
{
    public interface IResultadoBaseBacklogService
    {
        List<Resultado> Unificar(List<Resultado> resultadoBackLogComTracking, List<BaseBacklog> listaDeBaseBacklog);
    }
}
