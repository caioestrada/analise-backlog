namespace AnaliseBacklog.Domain.Entities
{
    public class BackLog
    {
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
    }
}
