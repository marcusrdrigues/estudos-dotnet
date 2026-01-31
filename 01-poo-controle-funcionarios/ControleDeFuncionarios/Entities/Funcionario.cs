using ControleDeFuncionarios.Enums;

namespace ControleDeFuncionarios.Entities;

//Definição da classe
public class Funcionario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public DateOnly DataAdmissao { get; set; }
    public decimal Salario { get; set; }
    public DateTime DataHoraCadastro { get; set; } = DateTime.Now;

    #region Relacionamentos

    public Empresa? Empresa { get; set; }
    public TipoContratacao? TipoContratacao { get; set; }

    #endregion
}
