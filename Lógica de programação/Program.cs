using System;

namespace Lógica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("digite o seu nome");
            // string nomecompleto = Console.ReadLine();

            // Console.WriteLine("seja bem-vindo "+nomecompleto);

            //Entradas
            Console.WriteLine("soma de dois números");
            Console.WriteLine("....................");
            Console.Write("Digite o primeiro valor: ");
            int valorUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valorDois=int.Parse(Console.ReadLine());

            //Processamento 

            int soma = valorUm + valorDois;

            //exibir

            Console.WriteLine("soma de "+valorUm+" + "+valorDois+" = "+soma);



        }
    }
}
