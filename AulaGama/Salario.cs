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
            carga = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salario mensal");
            salario = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("O Salario mensal do funcinario: " + nome + " e: " + salario + " para a carga mensal de : " + carga);
            Boolean contInterno = true;
            Boolean outro = false;

            //while (contInterno)
            //{
            //    Console.WriteLine("Gostaria de saber de outro salario\nDigite sim ou nao");
            //    string repet = Console.ReadLine();


            //    switch (repet.ToLower())
            //    {
            //        case ("sim"):
            //            contInterno = false;
            //            outro = true;
            //            break;
            //        case ("nao"):
            //            contInterno = false;
            //            outro = false;
            //            break;
            //        default:
            //            contInterno = true;
            //            Console.WriteLine("Texto não permitido");
            //            break;


            //    }
            //}

            //if (outro)
            //    contInterno = true;
            while (contInterno)
            {
                Console.WriteLine("Qual salario gostaria de saber Ano, Semana, Dia, Hora, Decada, ou Outro, caso deseja sair digite 'sair' ");
                string tipoSalario = Console.ReadLine();
                switch (tipoSalario.ToLower())
                {
                    case ("ano"):
                        calcSalarioByTimeYear(salario);
                        break;
                    case ("dia"):
                        calcSalarioByTimeDay(salario);
                        break;
                    case ("hora"):
                        calcSalarioByTimeHour(salario);
                        break;
                    case ("decada"):
                        calcSalarioByTimeDecade(salario);
                        break;
                    case ("semana"):
                        calcSalarioByTimeWeek(salario);
                        break;
                    case ("outro"):
                        calcSalarioByTimeSpecial(salario);
                        break;
                    case ("mes"):
                        calcSalarioByTimeMonth(salario);
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

        public double calcSalarioByTime(double lsalario, char tipo)
        {



            switch (tipo)
            {
                case ('a'):
                    Console.WriteLine("O Salario do funcinario: " + nome + " e : " + lsalario * 12 + " ao Ano");
                    break;
                case ('d'):
                    Console.WriteLine("O Salario do funcinario: " + nome + " e : " + lsalario / 30 + " ao dia");
                    break;
                case ('h'):
                    Console.WriteLine("O Salario do funcinario: " + nome + " e : " + lsalario / carga + " ao hora");
                    break;
                case ('y'):
                    Console.WriteLine("O Salario do funcinario: " + nome + " e : " + (lsalario * 12) * 10 + " ao Decada");
                    break;

            }


            return lsalario;

        }

        public void calcSalarioByTimeYear(double lsalario)
        {
            Console.WriteLine("O Salario do funcinario: " + nome + " e : " + Math.Round(lsalario * 12, 2) + " ao Ano");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();

        }
        public void calcSalarioByTimeHour(double lsalario)
        {
            Console.WriteLine("O Salario do funcinario: " + nome + " e : " + Math.Round(lsalario / carga, 2) + " a hora");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        public void calcSalarioByTimeMonth(double lsalario)
        {
            Console.WriteLine("O Salario do funcinario: " + nome + " e : " + Math.Round(salario, 2) + " ao Mes");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        public void calcSalarioByTimeDay(double lsalario)
        {
            Console.WriteLine("O Salario do funcinario: " + nome + " e : " + Math.Round((lsalario / carga) * 8, 2) + " ao Dia");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        public void calcSalarioByTimeWeek(double lsalario)
        {
            Console.WriteLine("O Salario do funcinario: " + nome + " e : " + Math.Round((lsalario / carga) * (carga * 5), 2) + " a Semana");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();

        }
        public void calcSalarioByTimeSpecial(double lsalario)
        {

            Console.WriteLine("Qual salario gostaria de saber Ano, Semana, Dia, Hora");
            string tipoSalario = Console.ReadLine();
            switch (tipoSalario.ToLower())
            {
                case ("ano"):
                    Console.WriteLine("Digite a quantidade de Anos que gostaria de saber");
                    Int64 years = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O Salario do funcinario: " + nome + " e : " + Math.Round((lsalario * 12) * years, 2) + " a com  " + years + " Anos de trabalhos");
                    break;
                case ("dia"):
                    Console.WriteLine("Digite a quantidade  de dias que gostaria de saber");
                    Int64 days = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O Salario do funcinario: " + nome + " e : " + Math.Round(((lsalario / carga) * 8) * days, 2) + " a com  " + days + " Dias de trabalhos");
                    break;
                case ("hora"):
                    Console.WriteLine("Digite a quantidade  de horas que gostaria de saber");
                    Int64 hours = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O Salario do funcinario: " + nome + " e : " + Math.Round((lsalario / carga) * hours, 2) + " a com  " + hours + " horas de trabalhos");
                    break;
                case ("mes"):
                    Console.WriteLine("Digite a quantidade  de meses que gostaria de saber");
                    Int64 months = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O Salario do funcinario: " + nome + " e : " + Math.Round(lsalario * months, 2) + " a com  " + months + " meses de trabalhos");
                    break;

                default:
                    Console.WriteLine("Texto não permitido");
                    break;
            }

            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();


        }
        public void calcSalarioByTimeDecade(double lsalario)
        {

            Console.WriteLine("O Salario do funcinario: " + nome + " e : " + (lsalario * 12) * 10 + " a Decada");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();


        }

    }
}
