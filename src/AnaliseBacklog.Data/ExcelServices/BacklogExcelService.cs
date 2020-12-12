using AnaliseBacklog.Domain.Entities;
using AnaliseBacklog.Domain.Interfaces.ExcelServices;
using System;
using System.Collections.Generic;
using System.Data;

namespace AnaliseBacklog.Data.ExcelServices
{
    public class BacklogExcelService : BaseService, IBacklogExcelService
    {
        public List<BackLog> ObterTodos(string caminhoDaPlanilha)
        {
            try
            {
                var listaDeBacklog = new List<BackLog>();
                var dt = ObterDataTableApartirDoExcel(caminhoDaPlanilha);

                foreach (DataRow dr in dt.Rows)
                    listaDeBacklog.Add(new BackLog
                    {
                        Id = ConverterPedidoProdutoEmIdBacklog(dr["No Pedido"].ToString(), dr["Produto"].ToString()),
                        AnoXMes = dr["Ano X Mês"].ToString().Trim(),
                        EmissaoPedido = dr["Emissao Pedido"].ToString().Trim(),
                        NumeroPedido = dr["No Pedido"].ToString().Trim(),
                        DataEntrega = dr["Data Entrega "].ToString().Trim(),
                        Cliente = dr["Cliente"].ToString().Trim(),
                        Fornecedor = dr["Fornecedor"].ToString().Trim(),
                        Itens = dr["Itens"].ToString().Trim(),
                        Produto = dr["Produto"].ToString().Trim(),
                        AnaliseBacklog = dr["Análise Backlog"].ToString().Trim(),
                        TotalItensPedido = dr["Total Itens Ped (Qtde)"].ToString().Trim(),
                        PedidosEmAberto = dr["Pedidos em aberto + fat mês"].ToString().Trim()
                    });

                return listaDeBacklog;
            }
            catch (Exception)
            {
                return new List<BackLog>();
            }
        }

        private string ConverterPedidoProdutoEmIdBacklog(string noPedido, string produto)
        {
            if (string.IsNullOrEmpty(produto))
                return string.Empty;

            var separador = produto.IndexOf(' ');
            var identificadorDoProduto = produto.Substring(0, separador);

            return $"{noPedido.Trim()} - {identificadorDoProduto.Trim()}";
        }
    }
}
