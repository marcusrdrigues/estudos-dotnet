using ControleDeFuncionarios.Entities;
using ControleDeFuncionarios.Enums;
using ControleDeFuncionarios.UseCases;

namespace ControleDeFuncionarios.Controllers;

/// <summary>
/// Controlador para entrada de dados de funcionário
/// </summary>
public class FuncionarioController
{
    /// <summary>
    /// Método para manter dados de funcionários
    /// </summary>
    public void GerenciarFuncionarios()
    {
        Console.WriteLine("\n*** SISTEMA PARA GERENCIAMENTO DE FUNCIONÁRIOS: ***\n");

        Console.WriteLine("(1) CADASTRAR FUNCIONÁRIO");
        Console.WriteLine("(2) CONSULTAR FUNCIONÁRIO");

        Console.Write("\nINFORME A OPÇÃO DESEJADA: ");
        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1": RealizarCadastro();
                break;
            case "2": RealizarConsulta();
                break;
            default:
                Console.WriteLine("\nOPÇÃO INVÁLIDA!");
                return;
        }
    }

    private void RealizarCadastro()
    {
        Console.WriteLine("\nCADASTRO DE FUNCIONÁRIO: \n");

        var funcionario = new Funcionario(); //Criando um objeto do funcionário
        funcionario.Empresa = new Empresa();
        
        Console.Write("NOME DO FUNCIONÁRIO......: ");
        funcionario.Nome = Console.ReadLine() ?? string.Empty;

        Console.Write("CPF..................: ");
        funcionario.Cpf = Console.ReadLine() ?? string.Empty;
        
        Console.Write("DATA DE ADMISSÁO.........: ");
        funcionario.DataAdmissao = DateOnly.Parse(Console.ReadLine() ?? string.Empty);
        
        Console.Write("SALÁRIO..................: ");
        funcionario.Salario = decimal.Parse(Console.ReadLine() ?? string.Empty);

        Console.Write("RAZAO SOCIAL DA EMPRESA..: ");
        funcionario.Empresa.RazaoSocial = Console.ReadLine() ?? string.Empty;
        
        Console.Write("NOME FANTASIA............: ");
        funcionario.Empresa.NomeFantasia = Console.ReadLine() ?? string.Empty;
        
        Console.Write("CNPJ.....................: ");
        funcionario.Empresa.Cnpj = Console.ReadLine() ?? string.Empty;
        
        Console.Write("TIPO DE CONTRATAÇÃO.......:");
        funcionario.TipoContratacao = Enum.Parse<TipoContratacao>(Console.ReadLine() ?? string.Empty);
        
        //Criando um objeto da classe UseCase
        var funcionarioUseCase = new FuncionarioUseCase();
        funcionarioUseCase.CadastrarFuncionario(funcionario);
        
        Console.WriteLine("\nFUNCIONÁRIO CADASTRADO COM SUCESSO!");
        
    }
    private void RealizarConsulta()
    {
        
    }
}