using System;
using System.Collections.Generic;

public class Estoque
{
    public Estoque(int idEstoque)
    {
        IdEstoque = idEstoque;
        _estoqueLista = new List<Estoque>();
        _estoque = new Dictionary<int, int>();
    }

    private Dictionary<int, int> _estoque;
    public List<Estoque> _estoqueLista;
    public int IdEstoque { get; set; }

    public bool VerificaDisponibilidade(Produto prod)
    {
        int qtd = _estoque[prod.Id];

        if (qtd > 0)
            return true;
        else
            return false;
    }
    public void CadastrarProduto(Produto prod, int qtdInicial)
    {
        _estoque.Add(prod.Id, qtdInicial);
    }
    public void DarBaixaDeProduto(Produto prod)
    {
        _estoque[prod.Id]--;
    }
}