using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - Soma \n2 - Subtração \n3 - Multiplicação \n4 - Divisão \n0 - SAIR");

            Console.WriteLine("--------- \nEscolha uma opção: ");
            short resposta = short.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultado = valor1 + valor2;

            #region METODOS DE RETORNO
            // Console.WriteLine("O resultado da soma é" + resultado);
            // Console.WriteLine("O resultado da soma é" + (valor1 + valor2));
            Console.WriteLine($"O resultado da soma é {resultado}");
            // Console.WriteLine($"O resultado da soma é {valor1 + valor2}");
            #endregion
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultado = valor1 - valor2;

            #region METODOS DE RETORNO
            // Console.WriteLine("O resultado da subtração é" + resultado);
            // Console.WriteLine("O resultado da subtração é" + (valor1 - valor2));
            Console.WriteLine($"O resultado da subtração é {resultado}");
            // Console.WriteLine($"O resultado da subtração é {valor1 - valor2}");
            #endregion
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultado = valor1 * valor2;

            #region METODOS DE RETORNO
            // Console.WriteLine("O resultado da multiplicação é" + resultado);
            // Console.WriteLine("O resultado da multiplicação é" + (valor1 * valor2));
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            // Console.WriteLine($"O resultado da multiplicação é {valor1 * valor2}");
            #endregion
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultado = valor1 / valor2;

            #region METODOS DE RETORNO
            // Console.WriteLine("O resultado da divisão é" + resultado);
            // Console.WriteLine("O resultado da divisão é" + (valor1 / valor2));
            Console.WriteLine($"O resultado da divisão é {resultado}");
            // Console.WriteLine($"O resultado da divisão é {valor1 / valor2}");
            #endregion
            Console.ReadKey();
            Menu();
        }
    }
}