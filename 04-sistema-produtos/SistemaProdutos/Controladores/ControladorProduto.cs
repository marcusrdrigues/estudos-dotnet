using SistemaProdutos.Entidades;
using SistemaProdutos.Enums;
using SistemaProdutos.Repositorios;

namespace SistemaProdutos.Controladores;

public class ControladorProduto
{
    public void CadastrarProduto()
    {
        Console.WriteLine("\nSeja bem vindo! Vamos cadastrar um novo produto:\n");

        var produto = new Produto();

        Console.Write("Informe o nome do produto............: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Informe o preço do produto...........: ");
        produto.Preco = decimal.Parse(Console.ReadLine());

        Console.Write("Informe a quantidade do produto..: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nListagem de categorias:");
        Console.WriteLine("\t(1) Informática");
        Console.WriteLine("\t(2) Eletrônicos");
        Console.WriteLine("\t(3) Games");
        Console.WriteLine("\t(4) Outros");
        
        Console.Write("Informe o código da categoria........: ");
        produto.Categoria = (Categoria) int.Parse(Console.ReadLine());
        
        //Criando um objeto da classe de repositorio de produto
        var repositorioProduto = new RepositorioProduto();
        
        //enviando o produto para ser salvo no banco de dados
        repositorioProduto.Salvar(produto);

        Console.WriteLine("\nProduto cadastrado com sucesso no banco de dados.");
    }
}