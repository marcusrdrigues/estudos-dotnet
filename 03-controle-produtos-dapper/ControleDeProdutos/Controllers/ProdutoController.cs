using ControleDeProdutos.entities;
using ControleDeProdutos.enums;
using ControleDeProdutos.Repositories;

namespace ControleDeProdutos.Controllers;

/// <summary>
/// Classe controladora para capturar os dados do produto
/// informado pelo usuário e enviá-lo para o repositório
/// </summary>
public class ProdutoController
{
    public void CadastrarProduto()
    {
        //Criando um objeto da classe Produto
        var produto = new Produto();
        
        Console.Write("NOME DO PRODUTO............: ");
        produto.Nome = Console.ReadLine() ?? string.Empty;
        
        Console.Write("PREÇO DO PRODUTO...........: ");
        produto.Preco = decimal.Parse(Console.ReadLine() ?? string.Empty);
        
        Console.Write("QUANTIDADE DO PRODUTO......: ");
        produto.Quantidade = int.Parse(Console.ReadLine() ?? string.Empty);
        
        Console.Write("CATEGORIA DO PRODUTO.......: ");
        produto.Categoria = Enum.Parse<Categoria>(Console.ReadLine() ?? string.Empty);
        
        //Criando um objeto da classe ProdutoRepository
        var produtoRespository = new ProdutoRepository();
        produtoRespository.Inserir(produto);
        
        Console.WriteLine("\nPRODUTO CADASTRADO COM SUCESSO!");
    }
}