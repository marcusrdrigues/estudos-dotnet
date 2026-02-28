using SistemaProdutos.Enums;

namespace SistemaProdutos.Entidades;

public class Produto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataHoraCadastro { get; set; } = DateTime.Now;
    public Categoria Categoria { get; set; }
    public Status Status 
    { 
        get
        {
            return Quantidade > 0 ? Status.Disponivel : Status.Indisponivel;
        }
    }
}