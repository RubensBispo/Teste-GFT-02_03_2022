using System;
using banco.Model;

namespace banco{
     public class Program
     {
        public static void Main(string[] args)
         {
            //  Corrente c = new Corrente();
            //  c.Creditar(100);
            //  c.ExibirSaldo();    
            Computador comp = new Computador();
            
            System.Console.WriteLine (comp.ToString());       
         }
     }
 }
