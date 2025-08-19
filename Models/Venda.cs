using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakStock.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Vendedor { get; set; }
        public List<Produto> ProdutosVendidos { get; set; }
        public decimal Total { get; set; }
        public decimal Desconto { get; set; }
    }

}
