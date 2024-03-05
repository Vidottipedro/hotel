using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a diaria do hotel?");
               double diaria = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos adultos vão na viagem?");
               double adultos = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas crianças vão na viagem?");
               double crianças = double.Parse(Console.ReadLine());

            double Valordia = (diaria * adultos) + (diaria * crianças / 2);

            Console.WriteLine("A diaria ira ser de: R$" + Valordia.ToString("C"));

            Console.WriteLine("Quantos dias a familia ira ficar no hotel");
                int dias = int.Parse(Console.ReadLine());

            double tt = Valordia * dias;
            
            Console.WriteLine("O total da viagem em familia sera de: "+tt.ToString("C"));

            Console.WriteLine("Quantas parcelas a familia ira parcelar?");
                int parcelas = int.Parse(Console.ReadLine());

            double ttp= tt / parcelas;

            Console.WriteLine("O valor de cada parcela sera de:" + ttp.ToString("C"));

            Console.ReadKey();



        }
    }
}
