using AnaliseBacklog.Domain.Entities;
using AnaliseBacklog.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace AnaliseBacklog.Domain.Services
{
    public class BacklogTrackingService : IBacklogTrackingService
    {
        public List<Resultado> Unificar(List<BackLog> listaDeBacklog, List<Tracking> listaDeTracking)
        {
            var resultado = new List<Resultado>();

            foreach (var backlog in listaDeBacklog)
            {
                var trackingDoBacklog = listaDeTracking.FirstOrDefault(tracking => tracking.Id == backlog.Id);
                if (trackingDoBacklog != null)
                {
                    resultado.Add(new Resultado
                    {
                        Id = backlog.Id,
                        AnoXMes = backlog.AnoXMes,
                        EmissaoPedido = backlog.EmissaoPedido,
                        NumeroPedido = backlog.NumeroPedido,
                        DataEntrega = backlog.DataEntrega,
                        Cliente = backlog.Cliente,
                        Fornecedor = backlog.Fornecedor,
                        Itens = backlog.Itens,
                        Produto = backlog.Produto,
                        AnaliseBacklog = backlog.AnaliseBacklog,
                        TotalItensPedido = backlog.TotalItensPedido,
                        PedidosEmAberto = backlog.PedidosEmAberto,
                        SolicitacaoCompra = trackingDoBacklog.SolicitacaoCompra,
                        DataSc = trackingDoBacklog.DataSc,
                        SolicitacaoImportacao = trackingDoBacklog.SolicitacaoImportacao,
                        DataSi = trackingDoBacklog.DataSi,
                        PurchOrder = trackingDoBacklog.PurchOrder,
                        DataPo = trackingDoBacklog.DataPo,
                        OrderConfirmation = trackingDoBacklog.OrderConfirmation,
                        DeliveryDate = trackingDoBacklog.DeliveryDate,
                        Processo = trackingDoBacklog.Processo,
                        Invoice = trackingDoBacklog.Invoice,
                        DataInvoice = trackingDoBacklog.DataInvoice
                    });
                }
            }

            return resultado;
        }
    }
}
