using AnaliseBacklog.Domain.Entities;
using AnaliseBacklog.Domain.Interfaces.ExcelServices;
using System;
using System.Collections.Generic;
using System.Data;

namespace AnaliseBacklog.Data.ExcelServices
{
    public class BaseBacklogExcelService : BaseService, IBaseBacklogExcelService
    {
        public List<BaseBacklog> ObterTodos(string caminhoDaPlanilha)
        {
            try
            {
                var listaDeBaseBacklog = new List<BaseBacklog>();
                var dt = ObterDataTableApartirDoExcel(caminhoDaPlanilha);

                foreach (DataRow dr in dt.Rows)
                    listaDeBaseBacklog.Add(new BaseBacklog
                    {
                        NumeroPedido = dr["C6_NUM"].ToString().Trim(),
                        Descricao = dr["E4_DESCRI"].ToString().Trim(),
                        DescricaoB1 = dr["DESC_B1"].ToString().Trim(),
                        Xtipseg = dr["XTIPSEG"].ToString().Trim(),
                        Xpropos = dr["C5_XPROPOS"].ToString().Trim(),
                        StatusDescricao = dr["X5_STATUS_Descricao"].ToString().Trim()
                    });

                return listaDeBaseBacklog;
            }
            catch (Exception)
            {
                return new List<BaseBacklog>();
            }
        }

        public bool GerarPlanilhaComResultado(List<Resultado> resultados)
        {
            return GerarPlanilha(resultados);
        }
    }
}
