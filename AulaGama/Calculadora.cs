using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGama
{
    internal class Calculadora
    {

        public double nota1;
        public double nota2;



        public double divicao()
        {


            return nota1/nota2;

        }

        public double adicao()
        {

            return nota1 + nota2;
        }
        
        public double multiplicacao()
        {

            return nota1 * nota2;
        }
        
        public double subtracao()
        {

            return nota1 - nota2;
        }
    }
}
