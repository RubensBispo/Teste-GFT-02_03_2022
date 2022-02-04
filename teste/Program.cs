using System;
using teste.Models;

namespace teste
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("informe o numero de meses : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            int vi = Convert.ToInt32(Console.ReadLine());
            
            Investimento investimento = new Investimento();
            investimento.calcularLucro(vi,m,j);
            investimento.imprimir();
        }
    }
}