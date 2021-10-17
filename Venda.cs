using System;
using System.Collections.Generic;
using System.Linq;
class Venda
{
    public Venda(int id, ICliente cliente, Estoque estoque, Loja loja)
    {
        Id = id;
        Cliente = cliente;
        _produtos = new List<Produto>();
        _estoque = estoque;
        Loja = loja;
    }
    private List<Produto> _produtos;
    private Estoque _estoque;
    public int Id { get; set; }
    public ICliente Cliente { get; set; }
    public Loja Loja { get; set; }

    public void AddProduto(Produto prod)
    {
        if (_estoque.IdEstoque == Loja.IdEstoque)
        {
            if (_estoque.VerificaDisponibilidade(prod))
            {
                _produtos.Add(prod);
                _estoque.DarBaixaDeProduto(prod);
                var vt = ValorTotal(prod);
                Console.WriteLine($"Produto: {prod.Nome} | Id do Estoque: {_estoque.IdEstoque} | Valor: {vt}");
            }
        }
    }
    public decimal ValorTotal(Produto prod)
    {
        decimal vt = 0;
        vt += prod.Preco;
        return vt;
    }
}
