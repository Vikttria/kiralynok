using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok
{
    class Program
    {
        static void Main(string[] args)
        {
            Tábla tabla = new Tábla('#');

            Console.WriteLine("4. feladat: Az üres tábla:");
            tabla.Megjelenít();
            Console.WriteLine();

            Console.WriteLine("6. feladat: A feltöltött tábla:");
            tabla.Elhelyez(8);
            tabla.Megjelenít();
            Console.WriteLine();


            Console.WriteLine("9. feladat: Üres oszlopok és sorok száma:");
            Console.WriteLine($"Oszlopok: {tabla.ÜresOszlopokSzáma}");
            Console.WriteLine($"Sorok: {tabla.ÜresSorokSzáma}");

            //
            Tábla tabla64 = new Tábla('*');
            tabla64.Fájlbaír();


            Console.ReadKey();
        }
    }
}
