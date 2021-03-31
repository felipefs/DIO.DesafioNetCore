using System;

namespace DIO.DesafiosNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Desafio DIO!");
                Console.WriteLine("Escolha as opções:");
                Console.WriteLine("1 - Opção Coordenadas de um Ponto.");
                Console.WriteLine("4 - Sair.");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                       // Media.CalculaMedia();
                        break;
                    
                    case 4:
                        Console.WriteLine("Até Mais!");
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
