using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGama
{
    internal class Notas
    {

        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;
        

        public double NotaTotal()
        { 


        return nota1 + nota2 + nota3 + nota4;
        
        }

        public double media()
        {
         
            return (nota1 + nota2 + nota3 + nota4)/4;
        }  
      

    }
}
