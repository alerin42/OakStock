using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakStock.Models
{
    public class MovimentacaoEstoque
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; } // "entrada" ou "saida"
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
    }

}
