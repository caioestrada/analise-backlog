using AnaliseBacklog.Domain.Entities;
using AnaliseBacklog.Domain.Interfaces.ExcelServices;
using System;
using System.Collections.Generic;
using System.Data;

namespace AnaliseBacklog.Data.ExcelServices
{
    public class TrackingExcelService : BaseService, ITrackingExcelService
    {
        public List<Tracking> ObterTodos(string caminhoDaPlanilha)
        {
            try
            {
                var listaDeTracking = new List<Tracking>();
                var dt = ObterDataTableApartirDoExcel(caminhoDaPlanilha);

                foreach (DataRow dr in dt.Rows)
                    listaDeTracking.Add(new Tracking
                    {
                        Id = ConverterPedidoProdutoEmIdTracking(dr["PED.VENDA"].ToString(), dr["PRODUTO"].ToString()),
                        PedidoVenda = dr["PED.VENDA"].ToString().Trim(),
                        Produto = dr["PRODUTO"].ToString().Trim(),
                        SolicitacaoCompra = dr["SOLIC.COMPRA"].ToString().Trim(),
                        DataSc = dr["DATA SC"].ToString().Trim(),
                        SolicitacaoImportacao = dr["SOLIC. IMPORT"].ToString().Trim(),
                        DataSi = dr["DATA SI"].ToString().Trim(),
                        PurchOrder = dr["PURCH. ORDER"].ToString().Trim(),
                        DataPo = dr["DATA P.O."].ToString().Trim(),
                        OrderConfirmation = dr["ORDER CONFIRMATION"].ToString().Trim(),
                        DeliveryDate = dr["DELIVERY DATE"].ToString().Trim(),
                        Processo = dr["PROCESSO"].ToString().Trim(),
                        Invoice = dr["INVOICE"].ToString().Trim(),
                        DataInvoice = dr["DATA INVOICE"].ToString().Trim()
                    });

                return listaDeTracking;
            }
            catch(Exception)
            {
                return new List<Tracking>();
            }
        }

        private static string ConverterPedidoProdutoEmIdTracking(string pedidoVenda, string produto)
        {
            return $"{pedidoVenda.Trim()} - {produto.Trim()}";
        }
    }
}
