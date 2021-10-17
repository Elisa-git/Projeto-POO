using System;

class EntregaCorreios : ITipoFrete
{
    public void Frete(Venda venda)
    {
        Console.WriteLine("Seu produto chegará em 20 dias úteis");
    }
}