/*

Desafio
Pink e Cérebro dividem um apartamento e estão juntos 24h por dia desde o começo da pandemia. 
Para passar o temp, Pink cria problemas matemáticos para Cérebro resolver, o último deles foi uma lista de números 
com a seguinte pergunta: quantos números da lista são múltiplos de 2, 3, 4 e 5?

Apesar de parecer simples, porém, quando a lista contém muitos números, Cérebro se confunde e acaba errando alguns cálculos.

Ajude Cérebro a resolver o desadio de Pink.

Entrada
A primeira linha da entrada consiste em um inteiro N (1 ≤ N ≤1000), representando a quantidade de números na lista de Pink.

A segunda linha contém N inteiros Li (1 ≤ Li ≤ 100), representando os números da lista de Pink.

Saída
Imprima a quantidade de números múltiplos de 2, 3, 4 e 5 presentes na lista. Observe a formatação da saída nos exemplos, 
pois ela deve ser seguida rigorosamente.

Exemplo de Entrada	
5
2 5 4 20 10

Exemplo de Saída
4 Multiplo(s) de 2
0 Multiplo(s) de 3
2 Multiplo(s) de 4
3 Multiplo(s) de 5

*/

using System;

namespace DIO.DesafiosNetCore
{
    public class PinkCerebro
    {
        public static void FazCalculos(){
            
            int n = int.Parse(Console.ReadLine());

            int Multiplo2 = 0;
            int Multiplo3 = 0;
            int Multiplo4 = 0;
            int Multiplo5 = 0;

            if (n < 1 || n > 1000){
                //return;
            }

            string[] Li = Console.ReadLine().Split();

            if (Li.Length < 1 || Li.Length > 100){
                //return;
            }

            if (Li.Length != n){
                //return;
            }

            for (int x=0 ; x < n; x++ )
            {
                int numDig = int.Parse(Li[x]);
                if (numDig % 2 == 0){ Multiplo2++;}
                if (numDig % 3 == 0){ Multiplo3++;}
                if (numDig % 4 == 0){ Multiplo4++;}
                if (numDig % 5 == 0){ Multiplo5++;}
            }

            Console.WriteLine("{0} Multiplo(s) de 2", Multiplo2);
            Console.WriteLine("{0} Multiplo(s) de 3", Multiplo3);
            Console.WriteLine("{0} Multiplo(s) de 4", Multiplo4);
            Console.WriteLine("{0} Multiplo(s) de 5", Multiplo5);

        }

        
    }
}