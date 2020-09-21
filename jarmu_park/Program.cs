using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jarmu_park
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto lada = new Auto("piros","Lada 2112",11);
            Auto trabant = new Auto("zöld","Trabant 1.1",8);

            lada.Tankol(20);
            trabant.Tankol(20);

            lada.Allapot();
            trabant.Allapot();

            Console.WriteLine("Mennyit megy a lada: ");
            int km = int.Parse(Console.ReadLine());
            lada.Megy(km);
            lada.Allapot();

            Console.WriteLine($"Maradt: {lada.UZEMANYAG} l - {lada.MEGTEHETOKM} km.");

            Console.WriteLine("Mennyit megy a trabant: ");
            int km2 = int.Parse(Console.ReadLine());
            trabant.Megy(km2);
            trabant.Allapot();


            Console.ReadKey();
        }
    }
}
