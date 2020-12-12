using AnaliseBacklog.Domain.Entities;
using System.Collections.Generic;

namespace AnaliseBacklog.Domain.Interfaces.ExcelServices
{
    public interface IBaseBacklogExcelService
    {
        List<BaseBacklog> ObterTodos(string caminhoDaPlanilha);
        bool GerarPlanilhaComResultado(List<Resultado> resultados);
    }
}
