using ControleDeProdutos.Controllers;

Console.WriteLine("\nCADASTRO DE PRODUTOS:\n");

//Criando um objeto da classe de controle
var produtoController = new ProdutoController();

//Executando o cadastro de produto
produtoController.CadastrarProduto();

//Pausar a execução
Console.ReadKey();