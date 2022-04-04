using System;

namespace Projeto__1__online
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolheusair = false;
            while (!escolheusair)
            {
                Console.WriteLine("seja bem vindo a calculadora Cléas/n selecione uma das opçoes: ");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        multiplicasao();
                        break;
                    case Menu.Raiz:
                        raiz();
                        break;
                    case Menu.Potencia:
                        pot();
                        break;
                    case Menu.Sair:
                        escolheusair = true;
                        break;

                }
                Console.Clear();
            }
        }
        static void Soma()
        {
            Console.WriteLine("soma dois numeros: ");
            Console.WriteLine("digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"resultado é: {resultado} ");
            Console.WriteLine("aperte enter para voltar para o menu");
            Console.ReadLine();
        }
        static void subtracao()
        {
            Console.WriteLine("subtração dois numeros: ");
            Console.WriteLine("digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"resultado é: {resultado} ");
            Console.WriteLine("aperte enter para voltar para o menu");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.WriteLine("divisao dois numeros: ");
            Console.WriteLine("digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"resultado é: {resultado} ");
            Console.WriteLine("aperte enter para voltar para o menu");
            Console.ReadLine();
        }
        static void multiplicasao()
        {
            Console.WriteLine("multiplicação dois numeros: ");
            Console.WriteLine("digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"resultado é: {resultado} ");
            Console.WriteLine("aperte enter para voltar para o menu");
            Console.ReadLine();
        }
        static void pot()
        {
            Console.WriteLine("potemcia de um numero ");
            Console.WriteLine("digite a base");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o expoente");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(basenum, expo);
            Console.WriteLine($"resultado é: {resultado} ");
            Console.WriteLine("aperte enter para voltar para o menu");
            Console.ReadLine();
        }
        static void raiz()
        {
            Console.WriteLine("raiz de um numero ");
            Console.WriteLine("digite o numero");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"resultado é: {resultado} ");
            Console.WriteLine("aperte enter para voltar para o menu");
            Console.ReadLine();
        }
    }
}
