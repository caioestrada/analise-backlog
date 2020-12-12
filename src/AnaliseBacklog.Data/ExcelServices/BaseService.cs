using AnaliseBacklog.Domain.Entities;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace AnaliseBacklog.Data.ExcelServices
{
    public class BaseService
    {
        public DataTable ObterDataTableApartirDoExcel(string path, bool hasHeader = true)
        {
            using (var pck = new ExcelPackage())
            {
                using (var stream = File.OpenRead(path))
                    pck.Load(stream);

                var ws = pck.Workbook.Worksheets.FirstOrDefault();
                DataTable tbl = new DataTable();

                foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                    tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));

                var startRow = hasHeader ? 2 : 1;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                    DataRow row = tbl.Rows.Add();
                    foreach (var cell in wsRow)
                        row[cell.Start.Column - 1] = cell.Text;
                }

                return tbl;
            }
        }

        public bool GerarPlanilha(List<Resultado> resultados)
        {
            try
            {
                string caminhoDoArquivo = $"{AppDomain.CurrentDomain.BaseDirectory}";
                string nomeDoArquivo = "Analise_Backlog";

                FileInfo file = new FileInfo(Path.Combine(caminhoDoArquivo, $"{nomeDoArquivo}.xlsx"));

                if (file.Exists)
                    file = new FileInfo(Path.Combine(caminhoDoArquivo, $"{nomeDoArquivo}_{DateTime.Now.Ticks}.xlsx"));

                using (ExcelPackage package = new ExcelPackage(file))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Analise_Backlog");
                    InserirNomeDeColunas(worksheet);
                    InserirResultado(resultados, worksheet);

                    package.Save();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static void InserirResultado(List<Resultado> resultados, ExcelWorksheet worksheet)
        {
            var linha = 2;
            foreach (var resultado in resultados)
            {
                worksheet.Cells[linha, 1].Value = resultado.Id;
                worksheet.Cells[linha, 2].Value = resultado.AnoXMes;
                worksheet.Cells[linha, 3].Value = resultado.EmissaoPedido;
                worksheet.Cells[linha, 4].Value = resultado.NumeroPedido;
                worksheet.Cells[linha, 5].Value = resultado.DataEntrega;
                worksheet.Cells[linha, 6].Value = resultado.Cliente;
                worksheet.Cells[linha, 7].Value = resultado.Fornecedor;
                worksheet.Cells[linha, 8].Value = resultado.Itens;
                worksheet.Cells[linha, 9].Value = resultado.Produto;
                worksheet.Cells[linha, 10].Value = resultado.AnaliseBacklog;
                worksheet.Cells[linha, 11].Value = resultado.TotalItensPedido;
                worksheet.Cells[linha, 12].Value = resultado.PedidosEmAberto;
                worksheet.Cells[linha, 13].Value = resultado.SolicitacaoCompra;
                worksheet.Cells[linha, 14].Value = resultado.DataSc;
                worksheet.Cells[linha, 15].Value = resultado.SolicitacaoImportacao;
                worksheet.Cells[linha, 16].Value = resultado.DataSi;
                worksheet.Cells[linha, 17].Value = resultado.PurchOrder;
                worksheet.Cells[linha, 18].Value = resultado.DataPo;
                worksheet.Cells[linha, 19].Value = resultado.OrderConfirmation;
                worksheet.Cells[linha, 20].Value = resultado.DeliveryDate;
                worksheet.Cells[linha, 21].Value = resultado.Processo;
                worksheet.Cells[linha, 22].Value = resultado.Invoice;
                worksheet.Cells[linha, 23].Value = resultado.DataInvoice;
                worksheet.Cells[linha, 24].Value = resultado.Descricao;
                worksheet.Cells[linha, 25].Value = resultado.DescricaoB1;
                worksheet.Cells[linha, 26].Value = resultado.Xtipseg;
                worksheet.Cells[linha, 27].Value = resultado.Xpropos;
                worksheet.Cells[linha, 28].Value = resultado.StatusDescricao;

                linha++;
            }
        }

        private static void InserirNomeDeColunas(ExcelWorksheet worksheet)
        {
            worksheet.Cells[1, 1].Value = "Id";
            worksheet.Cells[1, 2].Value = "Ano X Mês";
            worksheet.Cells[1, 3].Value = "Emissão Pedido";
            worksheet.Cells[1, 4].Value = "Numero Pedido";
            worksheet.Cells[1, 5].Value = "Data Entrega";
            worksheet.Cells[1, 6].Value = "Cliente";
            worksheet.Cells[1, 7].Value = "Fornecedor";
            worksheet.Cells[1, 8].Value = "Itens";
            worksheet.Cells[1, 9].Value = "Produto";
            worksheet.Cells[1, 10].Value = "Análise Backlog";
            worksheet.Cells[1, 11].Value = "Total Itens Pedido";
            worksheet.Cells[1, 12].Value = "Pedidos Em Aberto";
            worksheet.Cells[1, 13].Value = "Solicitação Compra";
            worksheet.Cells[1, 14].Value = "Data Sc";
            worksheet.Cells[1, 15].Value = "Solicitação Importação";
            worksheet.Cells[1, 16].Value = "Data Si";
            worksheet.Cells[1, 17].Value = "Purch Order";
            worksheet.Cells[1, 18].Value = "Data Po";
            worksheet.Cells[1, 19].Value = "Order Confirmation ";
            worksheet.Cells[1, 20].Value = "Delivery Date";
            worksheet.Cells[1, 21].Value = "Processo";
            worksheet.Cells[1, 22].Value = "Invoice";
            worksheet.Cells[1, 23].Value = "Data Invoice";
            worksheet.Cells[1, 24].Value = "Descrição";
            worksheet.Cells[1, 25].Value = "Descricao B1";
            worksheet.Cells[1, 26].Value = "Xtipseg";
            worksheet.Cells[1, 27].Value = "Xpropos";
            worksheet.Cells[1, 28].Value = "Status Descrição";
        }
    }
}