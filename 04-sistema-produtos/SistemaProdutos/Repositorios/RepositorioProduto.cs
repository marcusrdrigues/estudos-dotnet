using Dapper;
using Microsoft.Data.SqlClient;
using SistemaProdutos.Entidades;

namespace SistemaProdutos.Repositorios;

public class RepositorioProduto
{
    public void Salvar(Produto produto)
    {
        //Conectando no banco de dados
        using (var connection = new SqlConnection(
                   "Server=localhost,1433;Database=DBProdutos;User Id=sa;Password=Marcus$2026;TrustServerCertificate=True;"))
        {
            //Escrever o comando SQL para inserir os dados do produto no banco
            var sql = """
                      INSERT INTO PRODUTOS(ID, NOME, PRECO, QUANTIDADE, DATAHORACADASTRO, CATEGORIA, STATUS)
                      VALUES(@Id, @Nome, @Preco, @Quantidade, @DataHoraCadastro, @Categoria, @Status)
                      """;
            
            //Executar o comando SQL no banco de dados
            connection.Execute(sql, produto);
        }
    }
}