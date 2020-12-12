using AnaliseBacklog.Domain.Entities;
using System.Collections.Generic;

namespace AnaliseBacklog.Domain.Interfaces.ExcelServices
{
    public interface ITrackingExcelService
    {
        List<Tracking> ObterTodos(string caminhoDaPlanilha);
    }
}
