using System;
using System.IO;

namespace teste.Models
{
    public class Investimento
    {
        #region 
        public double jurosMensais { get; set; }        
        public double valorIncial { get; set; }
        public double meses { get; set; }
        public double retorno{get;set;}
        #endregion

        public double calcularLucro(int valorInicial,int meses, double juros)
        {
            this.valorIncial = valorInicial;
            this.meses = meses;
            this.jurosMensais = (Math.Pow(1+((juros/100)),this.meses));

            this.retorno = (this.valorIncial*(this.jurosMensais));
            return this.retorno = this.retorno - this.valorIncial;
        }

        public void imprimir()
        {
            System.Console.WriteLine($"retorno {this.retorno}");
        }
        
        
         
    }
}