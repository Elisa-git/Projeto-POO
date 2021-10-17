using System;

class RetiraNaLoja : IRetiraNaLoja
{
    public void Frete(Venda venda)
    {
        Console.WriteLine("Seu produto chegará em 3 dias úteis");
        RetirarNaLoja();
    }

    public void RetirarNaLoja()
    {
        Console.WriteLine("Seu produto será redirecionado a unidade mais próxima");
    }
}