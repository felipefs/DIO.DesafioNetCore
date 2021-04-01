/*

Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
A seguir, determine qual o quadrante ao qual pertence o ponto, 
ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

   y
Q2 | Q1
------- x
Q3 | Q4

Entrada
A entrada contem as coordenadas de um ponto.

Saída
A saída deve apresentar o quadrante em que o ponto se encontra.

*/
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