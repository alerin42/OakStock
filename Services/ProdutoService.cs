using MySqlConnector;
using OakStock.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OakStock.Services
{
    public class ProdutoService
    {
        private readonly string _connectionString;

        public ProdutoService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Produto> GetAllProdutos()
        {
            var produtos = new List<Produto>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Produto", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    produtos.Add(new Produto
                    {
                        Id = reader.GetInt32("Id"),
                        Nome = reader.GetString("Nome"),
                        Categoria = reader.GetString("Categoria"),
                        PrecoVenda = reader.GetDecimal("PrecoVenda"),
                        QuantidadeEstoque = reader.GetInt32("QuantidadeEstoque"),
                        Fornecedor = reader.GetString("Fornecedor")
                    });
                }
            }
            return produtos;
        }

        public void AddProduto(Produto produto)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO Produto (Nome, Categoria, Descricao, PrecoVenda, QuantidadeEstoque, Fornecedor) VALUES (@Nome, @Categoria, @Descricao, @PrecoVenda, @QuantidadeEstoque, @Fornecedor)", connection);
                command.Parameters.AddWithValue("@Nome", produto.Nome);
                command.Parameters.AddWithValue("@Categoria", produto.Categoria);
                command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                command.Parameters.AddWithValue("@PrecoVenda", produto.PrecoVenda);
                command.Parameters.AddWithValue("@QuantidadeEstoque", produto.QuantidadeEstoque);
                command.Parameters.AddWithValue("@Fornecedor", produto.Fornecedor);
                command.ExecuteNonQuery();
            }
        }
    }

}
