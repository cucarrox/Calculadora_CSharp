using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePraticaC__Calculadora
{
    internal class Divisao
    {

        public double CalcularDivisao(double n1, double n2)
        {
            if (n2 != 0)
                return n1 / n2;
            else
            {
                Console.WriteLine("Erro: Divisão por zero!");
                return 0;
            }
        }
    }
}
