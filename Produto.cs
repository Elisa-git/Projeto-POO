public class Produto
{
    public Produto(int id, string categoria, string nome, decimal preco)
    {
        Id = id;
        Categoria = categoria;
        Nome = nome;
        Preco = preco;
    }

    public int Id { get; set; }
    public string Categoria { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}