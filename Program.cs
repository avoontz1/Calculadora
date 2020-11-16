using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operação deseada
            //Primeiro valor
            //Segundo valor

            Console.WriteLine("Digite a operação desejada \nSoma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro valor a ser calculado:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor a ser calculado:");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = 0;   

            //utilizar switch sempre que as opções forem maiores que if e else, para que a aplicação seja mais performática

            switch(operacao){
                case "Soma":
                resultado = valor1 + valor2;
                break;

                case "Subtracao":
                resultado = valor1 - valor2;
                break;

                case "Multiplicacao":
                resultado = valor1 * valor2;
                break;

                case "Divisao":
                resultado = valor1 / valor2;
                break;
            }

            //Interpolação (pesquisar sobre)
            Console.WriteLine($"O calculo entre {valor1} e {valor2} resulta em: {resultado}");
        }
    }
}
