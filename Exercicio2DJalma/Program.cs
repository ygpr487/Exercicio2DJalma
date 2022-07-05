using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2DJalma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string mes, dia, ano;
            string cod;





            Console.WriteLine("CIDADES:\n");
            Console.WriteLine("1 = Atibaia ");
            Console.WriteLine("2 = Bragança Paulista ");
            Console.WriteLine("3 = Mairiporã ");
            Console.WriteLine("4 = Nazaré ");
            Console.WriteLine("5 = Terra Preta ");
            Console.WriteLine("6 = Extrema ");
            Console.WriteLine("7 = Vargem ");

            

            Console.Write("\nInforme o Número da cidade escolhida: ");
            cod = Console.ReadLine();



            switch (cod)
            {
                case "1":
                    cod = "Atibaia";

                    break;

                case "2":
                    cod = "Bragança Paulista";

                    break;

                case "3":
                    cod = "Mairiporã";

                    break;

                case "4":
                    cod = "Nazaré";

                    break;

                case "5":
                    cod = "Terra Preta";

                    break;

                case "6":
                    cod = "Extrema";

                    break;

                case "7":
                    cod = "Vargem";

                    break;

            }





            Console.Write("Informe uma data no formato dd/mm/yyyy: ");
            var dataescolhida = Convert.ToDateTime(Console.ReadLine());

           

            mes = Convert.ToString(dataescolhida.Month);
            dia = Convert.ToString(dataescolhida.Day);
            ano = Convert.ToString(dataescolhida.Year);

            


            Console.WriteLine();

            switch (mes)
            {


                case "1":
                    mes = "Janeiro";

                    break;
                case "2":
                    mes = "Fevereiro";

                    break;

                case "3":
                    mes = "Março";

                    break;
                case "4":
                    mes = "Abril";

                    break;


                case "5":
                    mes = "Maio";

                    break;
                case "6":
                    mes = "Junho";

                    break;

                case "7":
                    mes = "Julho";

                    break;
                case "8":
                    mes = "Agosto";
                    break;
                case "9":
                    mes = "Setembro";

                    break;
                case "10":
                    mes = "Outubro";

                    break;

                case "11":
                    mes = "Novembro";

                    break;
                case "12":
                    mes = "Dezembro";
                    break;



            }






            Console.WriteLine(cod + ", " + dia + " de " + mes + " de " + ano + ".");











            Console.ReadKey();
        }
    }
}
