using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace aula_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo Senac");
            Frases();

            Console.WriteLine("Aqui nova forma" + Soma(100, 10));
            Console.WriteLine("Aqui é o muliplica: " + Multiplica(100,10));

            Console.WriteLine("Aqui e o Divisão" + Divisao(100, 10));
          
            Console.WriteLine("Aqui e o Divisão" + Subtracao(100,10));

           



        }
        static void Frases()
        {
            Console.WriteLine("Olá pessoal"+"aula sobre metodo");
        }
        static double Soma(int n1, int n2)
        {
            double resultado;
            resultado = n1 + n2;
            return resultado;
            
               
            
        }
        static double Multiplica(int n1, int n2)
        {
            double resultado;
            resultado = n1 * n2;
            return resultado;

        }
        static double Divisao(int n1, int n2)
        {
            double resultado;
            resultado= n1 / n2;
            return resultado;


        }
        static double Subtracao(int n1, int n2)
        {
            double resultado;
            resultado = n1 - n2;
            return resultado;


        }
        

    }
}
