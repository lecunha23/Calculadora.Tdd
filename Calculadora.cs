using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Tdd
{
    public class Calculadora
    {
        private int _limineMinimo;

        public Calculadora(int limineMinimo = 0)
        {
            _limineMinimo = limineMinimo;
        }

        public int Somar(int a, int b)
        {
            if (( a < _limineMinimo) || ( b < _limineMinimo))
            {
                throw new ArgumentOutOfRangeException("O argumento está abaixo do limite minimo.");
            }
            return a + b;
        }

        public int Subtrair(int a, int b) 
        {
            if ((a < _limineMinimo) || (b < _limineMinimo))
            {
                throw new ArgumentOutOfRangeException("O argumento está abaixo do limite minimo.");
            }
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Dividir(int a, int b)
        {
            throw new NotImplementedException();
        }
    
    }
}
