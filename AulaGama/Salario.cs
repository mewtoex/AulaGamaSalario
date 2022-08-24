using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGama
{
    internal class Salario
    {
        string nome;
        double salario;
        double salarioAno;
        double salarioDia;
        double salarioHora;
        double salarioDecada;
        int carga;

        public void calcSalario()
        {

            Console.WriteLine("Digite o nome do funcionário");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua carga horaria mensal");
            carga = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o salario mensal");
            salario = Convert.ToInt16(Console.ReadLine());

            salarioDia = salario / 30;
            salarioHora = salario / carga;
            salarioAno = salario * 12;
            salarioDecada = salarioAno * 10;

            Console.WriteLine("O Salario do funcinario: " + nome + " e: " + salario + " para a carga mensal de : " + carga);
            Boolean contInterno = true;
            Boolean outro = false;

            while (contInterno)
            {
                Console.WriteLine("Gostaria de saber de outro salario\nDigite sim ou nao");
                string repet = Console.ReadLine();


                switch (repet.ToLower())
                {
                    case ("sim"):
                        contInterno = false;
                        outro = true;
                        break;
                    case ("nao"):
                        contInterno = false;
                        outro = false;
                        break;
                    default:
                        contInterno = true;
                        Console.WriteLine("Texto não permitido");
                        break;


                }
            }

            if (outro)
                contInterno = true;
            while (contInterno)
            {
                Console.WriteLine("Qual salario gostaria de saber Ano, Dia, Hora, Decada ou deseja sair");
                string tipoSalario = Console.ReadLine();


                switch (tipoSalario.ToLower())
                {
                    case ("ano"):
                        contInterno = true;

                        Console.WriteLine("O Salario do funcinario: " + nome + " e : " + salarioAno + " ao Ano");
                        break;
                    case ("dia"):
                        contInterno = true;

                        Console.WriteLine("O Salario do funcinario: " + nome + " e : " + salarioDia + " ao dia");

                        break;
                    case ("hora"):
                        contInterno = true;

                        Console.WriteLine("O Salario do funcinario: " + nome + " e : " + salarioHora + " ao hora");
                        break;
                    case ("Década"):
                        contInterno = true;

                        Console.WriteLine("O Salario do funcinario: " + nome + " e : " + salarioDecada + " ao Decada");
                        break;
                    case ("sair"):
                        contInterno = false;
                        break;
                    default:
                        contInterno = true;
                        Console.WriteLine("Texto não permitido");
                        break;


                }
            }


        }
    }
}
