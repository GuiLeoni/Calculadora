using System;

namespace Calculadora2
{
    class TestaCalculadora
    {
        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora();
            
            Console.WriteLine("Bem Vindo a calcuLEONI : ");
            Console.WriteLine("Digite: (1) = Soma");
            Console.WriteLine("Digite: (2) = Subtração");
            Console.WriteLine("Digite: (3) = Multiplicação");
            Console.WriteLine("Digite: (4) = Divisão");
            Console.WriteLine("Digite: (5) = Potenciação");
            Console.WriteLine("Digite: (6) = Raiz");
            Console.WriteLine("Digite: (9) = Sair");
            double escolha = Convert.ToDouble(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("Digite o 1° número a ser somado : ");
                double num1 = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Digite o 2° número a ser somado : ");
                double num2 = Convert.ToDouble(Console.ReadLine()); 
                c1.Somar(num1, num2);
                c1.ResultadoSoma();
            }
            else if(escolha == 2)
            {
                Console.WriteLine("Digite o 1° número a ser subtraido : ");
                double num1 = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Digite o 2° número a ser subtraido : ");
                double num2 = Convert.ToDouble(Console.ReadLine()); 
                c1.Subitrair(num1, num2);
                c1.ResultadoSubtracao();
            }
            else if(escolha == 3)
            {
                Console.WriteLine("Digite o 1° número a ser multiplicado : ");
                double num1 = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Digite o 2° número a ser multiplicado : ");
                double num2 = Convert.ToDouble(Console.ReadLine()); 
                c1.Multiplicar(num1, num2);
                c1.ResultadoMultiplicacao();
            }
            else if(escolha == 4)
            {
                Console.WriteLine("Digite o 1° número a ser dividido : ");
                double num1 = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Digite o 2° número a ser dividido : ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                c1.Dividir(num1, num2);
                c1.ResultadoDivisao();
            }
            else if(escolha == 5)
            {
                Console.WriteLine("Digite o  número a ser elevado : ");
                double num1 = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Digite o valor da elevação : ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                c1.Potenciar(num1, num2);
                c1.ResultadoPotenciacao();
            }
            else if(escolha == 6)
            {
                Console.WriteLine("Digite o que a descobrir a raiz : ");
                double num1 = Convert.ToDouble(Console.ReadLine()); 
                c1.Raizando(num1);
                c1.ResultadoRaiz();
            }
            Environment.Exit(9);
        }
    }
}
