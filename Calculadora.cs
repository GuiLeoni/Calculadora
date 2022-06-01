using System;

namespace Calculadora2
{
    public class Calculadora
    {
        public double num1 { get; set; } = 0;
        public double num2 { get; set; } = 0;
        public double num3 { get; set; } = 0;


        public double Somar(double num1, double num2){
        
            return this.num3 =  num1 + num2;
            
        }
        public void ResultadoSoma()
        {
            System.Console.WriteLine($"O Resultado da Soma é {num3}");
        }

        public double Subitrair(double num1, double num2)
        {
            return this.num3 = num1 - num2;
        }
        public void ResultadoSubtracao()
        {
            System.Console.WriteLine($"O Resultado da Subtração é {num3}");
        }

        public double Multiplicar(double num1, double num2){
        
            return this.num3 = num1 * num2;
        }
        public void ResultadoMultiplicacao()
        {
            System.Console.WriteLine($"O Resultado da Multiplicação é {num3}");
        }
        public double Dividir(double num1, double num2)
        {
            return this.num3 = num1 / num2;
        } 
        public void ResultadoDivisao()
        {
            System.Console.WriteLine($"O Resultado da Divisão é {num3}");
        }

        public double Potenciar(double num1, double num2){
        
            return this.num3 = Math.Pow(num1,num2); 
        }
        public void ResultadoPotenciacao()
        {
            System.Console.WriteLine($"O Resultado da Potência é {num3}");
        }

        public double Raizando(double num1)
        {
            return this.num3 = Math.Sqrt(num1);
        }
        public void ResultadoRaiz()
        {
            System.Console.WriteLine($"O Resultado da Raiz é {num3}");
        }

    }
}