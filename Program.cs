using System;

namespace Exercício___Escreva_10_valores_e_retorne_o_maior_e_o_menor
{
    // Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
    // menor valor lido.
    class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int [10];
            int maior =0;
            int menor=0;

            Console.WriteLine("Digite 10 valores aleatórios!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i+1}º valor:");
                valor[i] = int.Parse(Console.ReadLine());
                if(i==0)
                {
                    maior=valor[0];
                    menor=valor[0];
                }
                if(valor[i] < menor)
                {
                    menor=valor[i];
                }
                else if(valor[i]> maior)
                {
                    maior=valor[i];
                }
            }
            Console.WriteLine($"O menor valor é: {menor}");
            Console.WriteLine($"O maior valor é: {maior}");

        }
    }
}
