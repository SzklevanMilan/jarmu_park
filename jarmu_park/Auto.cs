using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jarmu_park
{
    class Auto
    {
        private string szin;
        private string tipus;
        private double uzemAnyag;
        private double fogyaszt;
        private double km;
        private double megtehetoKm;
        public Auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemAnyag = 0;
            this.km = 0;
            this.megtehetoKm = 0;

        }
        private void Megteheto()
        {
            megtehetoKm = uzemAnyag / fogyaszt * 100;
        }
        public void Tankol(double mennyit)
        {
            uzemAnyag += mennyit;
            Megteheto();
        }
        public void Megy(double km)
        {
            this.km += km;
            uzemAnyag -= (km * fogyaszt / 100);
            Megteheto();

        }
        public void Allapot()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km} km");
            Console.WriteLine($"Üzemanyag: {uzemAnyag} l");
            Console.WriteLine($"Megtehető km: {megtehetoKm}");
            Console.WriteLine("---------------------");
        }
    }
}
