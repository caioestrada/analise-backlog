using AnaliseBacklog.Domain.Entities;
using System.Collections.Generic;

namespace AnaliseBacklog.Domain.Interfaces.Services
{
    public interface IBacklogTrackingService
    {
        List<Resultado> Unificar(List<BackLog> listaDeBacklog, List<Tracking> listaDeTracking);
    }
}
