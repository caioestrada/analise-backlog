namespace AnaliseBacklog.Domain.Entities
{
    public class Tracking
    {
        public string Id { get; set; }
        public string PedidoVenda { get; set; }
        public string Produto { get; set; }
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
    }
}
