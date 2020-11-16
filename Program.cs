using System;

namespace calculadora_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação quer realiziar /nSoma , Subtracao, Multiplicacao , Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("digite o 1 numero");
            float num1 =float.Parse(Console.ReadLine());

            Console.WriteLine("digite o 2 numero");
            float num2 =float.Parse(Console.ReadLine());

            float resultado = 0f;

            switch(operacao){
                case "Soma" :
                resultado = num1 + num2 ;
                break;

                case "Subtracao" :
                resultado = num1 - num2 ;
                break;

                case "Multiplicacao" :
                resultado = num1 * num2 ;
                break;

                case "Divisao" :
                resultado = num1 / num2 ;
                break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

                Console.WriteLine($"Calculo : {num1} com {num2} = {resultado}");



        }
    }
}
