using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*vendas
             string[] nome = new string[5];
             double[] comi = new double[5];
             double[] tot = new double[5];

             for (int i = 0; i <= 4; i++)
             {
                 Console.Write("digite o nome do " +(i + 1) + "° vendedor:");
                 nome[i]= Console.ReadLine();

                 Console.Write("digite o total de vendas do " + (i + 1) + "° vendedor:");
                 tot[i] = double.Parse(Console.ReadLine());

                if (tot[i] <= 20000)
                 {
                     comi[i] = tot[i] * 0.05;   
                 }
                 else if (tot[i] <= 40000)
                 {
                     comi[i] = tot[i] * 0.06;
                 }
                else
                 {
                     comi[i] = tot[i] * 0.07;
                 }

                Console.Clear();

             }
             for (int j = 0; j <= 4; j++)
             {
                 Console.WriteLine("Vendedor " + nome[j] + ": teve um total de vendas de R$" + tot[j] + " e pagara uma comissão de R$" + comi[j]);


             }
            */

            string[] nome = new string[5];
            double[] imc = new double[5];
            double[] altura = new double[5];
            double[] peso = new double[5];
            string[] clas = new string[5];
            int aci = 0;
            double porcen = 0;

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("digite o seu nome:");
                nome[i] = Console.ReadLine();

                Console.Write("digite a sua altura(m):");
                altura[i] = double.Parse(Console.ReadLine());

                Console.Write("digite o seu peso:");
                peso[i] = double.Parse(Console.ReadLine());

                imc[i] = peso[i] / (altura[i] * altura[i]);

                if (imc[i] < 18.5)
                {
                    clas[i] = "abaixo do peso";
                }
                else if (imc[i] <= 24.9)
                {
                    clas[i] = "peso ideal";
                }                
                else if (imc[i] <= 29.9)
                {
                    clas[i] = "levemente acima do peso";
                    aci++;
                }
                else if (imc[i] <= 34.9)
                {
                    clas[i] = "obesidade grau I";
                    aci++;
                }
                else if (imc[i] <= 39.9)
                {
                    clas[i] = "obesidade grau II";
                    aci++;
                }
                else
                {
                    clas[i] = "obesidade grau III";
                    aci++;
                }



                Console.Clear();
                porcen = (aci / 5) * 100;

            }
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine( nome[j] + " tem " + altura[j] + "m de altura, pesa " + peso[j] + "Kg sendo " + clas[j] + "(" + imc[j] + ")");


            }
            Console.WriteLine("Estão acima do peso: " + porcen + "% do total");


            Console.ReadKey();
        }
    }
}
