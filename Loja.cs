using System;
using System.Collections.Generic;

class Loja
{
    public Loja(int idLoja, string nomeLoja, Estoque estoque, string cnpj, string cep)
    {
        IdLoja = idLoja;
        NomeLoja = nomeLoja;
        IdEstoque = estoque.IdEstoque;
        Cnpj = cnpj;
        Cep = cep;
    }

    public int IdLoja { get; set; }
    public string NomeLoja { get; set; }
    public int IdEstoque { get; set; }
    public string Cnpj { get; set; }
    public string Cep { get; set; }
}