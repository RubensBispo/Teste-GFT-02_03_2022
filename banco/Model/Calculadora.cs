using banco.Interface;

namespace banco.Model
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int x, int y, int z)
        {
            return x+y+z;
        }
        public int Dividir(int x, int y)
        {
           return x/y;
        }

        public int Multiplicar(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Somar(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Subtrair(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}