using ControleDeProdutos.entities;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ControleDeProdutos.Repositories;

/// <summary>
/// Repositório para acesso à banco de dados e
/// execução de operações com a tabela de Produto
/// </summary>
public class ProdutoRepository
{
    public void Inserir(Produto produto)
    {
        //Armazenar a string de conexão do banco de dados
        var connectionString = "Server=localhost,1433;Database=BDAula03;User Id=sa;Password=Marcus@2026;TrustServerCertificate=True;";
        
        //Abrir conexão com o banco de dados
        using (var connection = new SqlConnection(connectionString))
        {
            //Escrevendo o comando SQL que será executado no banco de dados
            var query = """
                    INSERT INTO PRODUTOS(NOME, PRECO, QUANTIDADE, CATEGORIA)
                    VALUES(@NOME, @PRECO, @QUANTIDADE, @CATEGORIA) 
                """;
            
            //Executar o comando SQL no banco de dados
            connection.Execute(query, new {
                @NOME = produto.Nome,
                @PRECO = produto.Preco,
                @QUANTIDADE = produto.Quantidade,
                @CATEGORIA = produto.Categoria.ToString()
            });
        }
    }
}