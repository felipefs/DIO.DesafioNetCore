using System;

namespace DIO.DesafiosNetCore
{
    public class CoordenadasPonto
    {

     public static void CoordenadasDeUmPonto(){

        decimal x, y;

        string[] valores = Console.ReadLine().Split();
        x = decimal.Parse(valores[0]);
        y = decimal.Parse(valores[1]);

        if (x == 0 && y == 0){
            Console.WriteLine("Origem");
        }
        else if (x > 0 && y > 0){
            Console.WriteLine("Q1");
        }
        else if (x < 0 && y > 0){
            Console.WriteLine("Q2");
        }
        else if (x < 0 && y < 0){
            Console.WriteLine("Q3");
        }
        else if (x > 0 && y < 0){
            Console.WriteLine("Q4");
        }
        else if (x == 0 && y != 0){
            Console.WriteLine("Eixo Y");
        }
        else if (x != 0 && y == 0){
            Console.WriteLine("Eixo X");
        }

     }  

    }
}