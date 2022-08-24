using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean nome = false;
            Boolean nomeTeste = false;
            //Console.WriteLine("Gostaria de ir para salario ou nome");
            while (nomeTeste)
            {
                Console.WriteLine("Deseja repetir\nDigite Sim ou Não");
                string repet = Console.ReadLine();


                switch (repet.ToLower())
                {
                    case ("calculadora"):
                        nome = true;
                        break;
                    case ("nome"):
                        nome = false;
                        break;
                    default:
                        nomeTeste = true;
                        Console.WriteLine("Texto não permitido");
                        break;


                }
            }
            if (nome)
            {
                Boolean cont = true;
                while (cont)
                {
                    Console.WriteLine("Digite seu nome");

                    Pessoa pessoa = new Pessoa();
                    Notas notas = new Notas();
                    pessoa.nome = Console.ReadLine();
                    Console.WriteLine("Digite sua idade");
                    pessoa.idade = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Seu nome e: " + pessoa.nome + "e sua idade e: " + pessoa.idade);
                    Console.WriteLine("Digite suas notas");

                    Console.WriteLine("Digite sua Primeira nota");
                    notas.nota1 = Convert.ToDouble(Console.ReadLine().ToString());
                    Console.WriteLine("Digite sua Segnda nota");
                    notas.nota2 = Convert.ToDouble(Console.ReadLine().ToString());
                    Console.WriteLine("Digite sua Treceira nota");
                    notas.nota3 = Convert.ToDouble(Console.ReadLine().ToString());
                    Console.WriteLine("Digite sua Quarta nota");
                    notas.nota4 = Convert.ToDouble(Console.ReadLine().ToString());
                    Console.WriteLine("Sua media e :" + notas.media());




                    Console.WriteLine("Seu nome soletrado e: ");

                    soletrando(pessoa.nome);
                    pessoa.LetraMeio();
                    Boolean contInterno = cont;
                    while (contInterno)
                    {
                        Console.WriteLine("Deseja repetir\nDigite Sim ou Não");
                        string repet = Console.ReadLine();


                        switch (repet.ToLower())
                        {
                            case ("sim"):
                                cont = true;
                                contInterno = false;
                                break;
                            case ("nao"):
                                cont = false;
                                contInterno = false;
                                break;
                            default:
                                cont = false;
                                contInterno = true;
                                Console.WriteLine("Texto não permitido");

                                break;


                        }
                    }
                    Console.Clear();

                }
            }
            else {
                Salario salario = new Salario();
                salario.calcSalario();
            }
           

        }


        public static void soletrando(string nome) 
        {
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);


            }

        }
    }
}
