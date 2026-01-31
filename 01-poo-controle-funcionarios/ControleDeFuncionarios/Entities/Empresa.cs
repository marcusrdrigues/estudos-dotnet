namespace ControleDeFuncionarios.Entities;

public class Empresa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string NomeFantasia { get; set; } = string.Empty;
    public string RazaoSocial { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public DateTime DataHoraCadastro { get; set; } = DateTime.Now;

    #region MyRegion

    public List<Funcionario>? Funcionarios { get; set; }

    #endregion
}