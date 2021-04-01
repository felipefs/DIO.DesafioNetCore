using System;

namespace DIO.DesafiosNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repete = true;
            
            while (repete)
            {
                
                try
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Desafio DIO!");
                    Console.WriteLine("Escolha as opções:");
                    Console.WriteLine("1 - Opção Coordenadas de um Ponto.");
                    Console.WriteLine("2 - Opção Compras no Supermercado.");
                    Console.WriteLine("4 - Sair.");

                    int opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            CoordenadasPonto.CoordenadasDeUmPonto();
                            break;
                        case 2:
                            ComprasSupermercado.ComprasNoSupermercado();
                            break;                    
                        case 4:
                            Console.WriteLine("Até Mais!");
                            repete = false;
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
    }
}
