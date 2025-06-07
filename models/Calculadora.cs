using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo_sozinho.models
{
    public class Calculadora
    {

        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public Calculadora(double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }


        public double Somar()
        {
            return Numero1 + Numero2;
        }

        public double Subtrair()
        {
            return Numero1 - Numero2;
        }

        public double Multiplicar()
        {
            return Numero1 * Numero2;
        }

        public double Dividir()
        {
            if (Numero2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero");
                return 0;
            }
            return Numero1 / Numero2;
        }
    }
}