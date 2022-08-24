using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGama
{
    internal class Pessoa
    {

        public string nome;
        public int idade;


        public void LetraMeio()
        {
            Console.WriteLine("Seu e letra do meio e: " + nome[nome.Length / 2 - 1]);

        }
    }
}

    
