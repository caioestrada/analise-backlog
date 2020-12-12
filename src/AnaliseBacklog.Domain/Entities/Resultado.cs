namespace AnaliseBacklog.Domain.Entities
{
    public class Resultado
    {
        //Backlog
        public string Id { get; set; }
        public string AnoXMes { get; set; }
        public string EmissaoPedido { get; set; }
        public string NumeroPedido { get; set; }
        public string DataEntrega { get; set; }
        public string Cliente { get; set; }
        public string Fornecedor { get; set; }
        public string Itens { get; set; }
        public string Produto { get; set; }
        public string AnaliseBacklog { get; set; }
        public string TotalItensPedido { get; set; }
        public string PedidosEmAberto { get; set; }
        // Tracking
        public string SolicitacaoCompra { get; set; }
        public string DataSc { get; set; }
        public string SolicitacaoImportacao { get; set; }
        public string DataSi { get; set; }
        public string PurchOrder { get; set; }
        public string DataPo { get; set; }
        public string OrderConfirmation { get; set; }
        public string DeliveryDate { get; set; }
        public string Processo { get; set; }
        public string Invoice { get; set; }
        public string DataInvoice { get; set; }
        // Base Backlog
        public string Descricao { get; set; }
        public string DescricaoB1 { get; set; }
        public string Xtipseg { get; set; }
        public string Xpropos { get; set; }
        public string StatusDescricao { get; set; }
    }
}
