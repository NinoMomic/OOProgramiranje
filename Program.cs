using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjeOcjenskaVjezba
{
    class GeometrijskoTijelo
    {
        double Volumen;
        double Oplosje;
        public static int BrojacTijela = 0;
    }
    class Kugla : GeometrijskoTijelo
    {
       static Kugla()
        {
            BrojacTijela++;
        }
    }  
    class Kvadar : GeometrijskoTijelo
    {
        static Kvadar()
        {
            BrojacTijela++;
        }
    }
    class Kocka : Kvadar
    {
        static Kocka()
        {
            BrojacTijela++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kugla x = new Kugla();
            Kvadar y = new Kvadar();
            Kocka z = new Kocka();

            Console.WriteLine("Definirana su " + GeometrijskoTijelo.BrojacTijela + " tijela.");  


            Console.ReadKey();

        }
    }
}
