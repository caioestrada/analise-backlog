using AnaliseBacklog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseBacklog.Domain.Interfaces.ExcelServices
{
    public interface IBacklogExcelService
    {
        List<BackLog> ObterTodos(string caminhoDaPlanilha);
    }
}
