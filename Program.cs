using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICliente cliente01 = Factory.GetCliente();
            cliente01.Id = 1;
            cliente01.Nome = "Victor Heringer";
            cliente01.Cpf = "123456789-19";
            cliente01.Endereco = "Vila Velha";

            Produto vestido = new Produto(001, "Vestido", "Vestido longo", 150);
            Produto calca = new Produto(002, "Calça", "Calça Jeans", 220);

            Estoque e1 = new Estoque(10);
            e1.CadastrarProduto(vestido, 10);
            e1.CadastrarProduto(calca, 20);
     
            Estoque e2 = new Estoque(20);
            e2.CadastrarProduto(vestido, 10);
            e2.CadastrarProduto(calca, 20);
       
            Estoque e3 = new Estoque(30);
            e3.CadastrarProduto(vestido, 10);
            e3.CadastrarProduto(calca, 20);
    
            Estoque e4 = new Estoque(40);
            e4.CadastrarProduto(vestido, 10);
            e4.CadastrarProduto(calca, 20);
      

            Loja l1 = new Loja(100, "Loja A", e1, "111.111.111/1111-11", "11111-111");
            Loja l2 = new Loja(200, "Loja B", e2, "222.222.222/2222-22", "22222-222");
            Loja l3 = new Loja(300, "Loja C", e3, "333.333.333/3333-33", "33333-333");
            Loja l4 = new Loja(400, "Loja D", e4, "444.444.444/4444-44", "44444-444");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n=========== LOJAS C&A ===========");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 1 - Comprar roupas            |");
            Console.WriteLine("| 2 - Sair                      |");
            Console.WriteLine("|                               |");
            Console.WriteLine("=================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digite a sua opção:");
            var opcao = int.Parse(Console.ReadLine());

            ITipoFrete correio = new EntregaCorreios();
            ITipoFrete empresa = new EntregaEmpresa();
            ITipoFrete retirar = new RetiraNaLoja();

            Venda venda01 = new Venda(111, cliente01, e1, l1);
            try
            {
                if (opcao == 1)
                {
                    int menuLoja()
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("\n============ OPÇÕES ============");
                        Console.WriteLine("|                              |");
                        Console.WriteLine("| 1 - Vestido longo            |");
                        Console.WriteLine("| 2 - Calça Jeans              |");
                        Console.WriteLine("| 3 - Escolher frete           |");
                        Console.WriteLine("| 9 - Sair                     |");
                        Console.WriteLine("|                              |");
                        Console.WriteLine("================================");
                        Console.ResetColor();
                        Console.WriteLine("Digite o o número do item:");
                        int menu = int.Parse(Console.ReadLine());

                        if (menu == 1)
                        {
                            venda01.AddProduto(vestido);
                            Console.WriteLine("\nAdicione mais produtos ou digite 9 para sair");
                            return menuLoja();
                        }
                        else if (menu == 2)
                        {
                            venda01.AddProduto(calca);
                            Console.WriteLine("\nAdicione mais produtos ou digite 9 para sair");
                            return menuLoja();
                        }
                        else if (menu == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("\n======= TIPOS DE ENTREGA =======");
                            Console.WriteLine("|                              |");
                            Console.WriteLine("| 1 - Entrega pelo Correios    |");
                            Console.WriteLine("| 2 - Entrega pela empresa     |");
                            Console.WriteLine("| 3 - Retirar na loja          |");
                            Console.WriteLine("| 9 - Cancelar compra          |");
                            Console.WriteLine("|                              |");
                            Console.WriteLine("================================");
                            Console.ResetColor();
                            Console.WriteLine("Digite o o número do item:");
                            int entrega = int.Parse(Console.ReadLine());
                            if (entrega == 1)
                            {
                                correio.Frete(venda01);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Agradecemos por ter comprado conosco!");
                                Console.ResetColor();
                            }
                            else if (entrega == 2)
                            {
                                empresa.Frete(venda01);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Agradecemos por ter comprado conosco!");
                                Console.ResetColor();
                            }
                            else if (entrega == 3)
                            {
                                retirar.Frete(venda01);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Agradecemos por ter comprado conosco!");
                                Console.ResetColor();
                            }

                        }
                        else if (menu == 9)
                        {
                            Console.WriteLine("Volte sempre!");
                        }
                        return menu;
                    }

                    menuLoja();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Agradecemos sua visita!");
                }
                Console.ResetColor();
            }



            catch
            {
                Console.WriteLine("Produto adicionado não possui estoque. Venda Cancelada");
            }

        }
    }
}