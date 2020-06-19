using System;

namespace bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcule as raízes de uma equação de segundo grau, utilizando o método de Bhaskara.

           //Uma equação do segundo grau é dada pela expressão abaixo: ax2+bx+c=0

            int a, b, c ;
            double x1, x2,delta;
            string A,B,C;

            Console.Write("Digite o valor de A: ");
            A=Console.ReadLine();
            a=int.Parse(A);

            Console.Write("Digite o valor de B: ");
            B=Console.ReadLine();
            b=int.Parse(B);

            Console.Write("Digite o valor de C: ");
            C=Console.ReadLine();
            c=int.Parse(C);

            delta = Math.Pow(b, 2) - 4*a*c;

            

            x1= (- b + (delta))/2*a;
            x2= (- b - (delta))/2*a;
            Console.Write("Resultado de x1 " + x1 + " Resultado de x2 " + x2);
            
            


        }
    }
}
