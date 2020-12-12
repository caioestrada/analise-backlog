using AnaliseBacklog.Domain.Entities;
using AnaliseBacklog.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace AnaliseBacklog.Domain.Services
{
    public class ResultadoBaseBacklogService : IResultadoBaseBacklogService
    {
        public List<Resultado> Unificar(List<Resultado> resultadoBackLogComTracking, List<BaseBacklog> listaDeBaseBacklog)
        {
            foreach (var resultado in resultadoBackLogComTracking)
            {
                var baseBacklogDoResultado = listaDeBaseBacklog.FirstOrDefault(baseBacklog => baseBacklog.NumeroPedido == resultado.NumeroPedido);
                if (baseBacklogDoResultado != null)
                {
                    resultado.Descricao = baseBacklogDoResultado.Descricao;
                    resultado.DescricaoB1 = baseBacklogDoResultado.DescricaoB1;
                    resultado.Xtipseg = baseBacklogDoResultado.Xtipseg;
                    resultado.Xpropos = baseBacklogDoResultado.Xpropos;
                    resultado.StatusDescricao = baseBacklogDoResultado.StatusDescricao;
                }
            }

            return resultadoBackLogComTracking;
        }
    }
}
