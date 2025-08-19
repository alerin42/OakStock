using OakStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakStock.Services
{
    public class RelatorioService
    {
        public void GerarRelatorioDiario(List<Venda> vendas)
        {
            var totalVendas = vendas.Sum(v => v.Total);
            // Lógica para gerar PDF ou Excel com total de vendas diário.
        }

        public void GerarRelatorioMensal(List<Venda> vendas)
        {
            var vendasPorCategoria = vendas.GroupBy(v => v.ProdutosVendidos.Select(p => p.Categoria));
            // Lógica para gerar gráfico e relatório mensal
        }
    }

}
