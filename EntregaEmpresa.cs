using System;

class EntregaEmpresa : ITipoFrete
{
    public void Frete(Venda venda)
    {
        Random aleatorio = new Random();
        Console.WriteLine("Seu produto chegará em 7 dias úteis");
        Console.WriteLine($"Valor do frete: R${aleatorio.Next(10, 20)}");
    }
}