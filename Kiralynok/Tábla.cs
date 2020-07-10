using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok
{
    class Tábla
    {
        Random r = new Random();

        private char[,] T;
        private char ÜresCella;

        private int üresOszlopokSzáma;
        public int ÜresOszlopokSzáma
        {
            get {
                üresOszlopokSzáma = 0;
                for (int i = 0; i < 8; i++)
                {
                    if (ÜresOszlop(i))
                    {
                        üresOszlopokSzáma++;
                    }
                }
                return üresOszlopokSzáma; }
            set { üresOszlopokSzáma = value; }
        }

        private int üresSorokSzáma;
        public int ÜresSorokSzáma
        {
            get {
                üresSorokSzáma = 0;
                for (int i = 0; i < 8; i++)
                {
                    if (ÜresSor(i))
                    {
                        üresSorokSzáma++;
                    }
                }
                return üresSorokSzáma; }
            set { üresSorokSzáma = value; }
        }

        public Tábla(char uresChar)
        {
            T = new char[8, 8];
            ÜresCella = uresChar;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    T[i, j] = ÜresCella;
                }
            }
        }

        public void Elhelyez(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int j, k;
                do
                {
                    j = r.Next(8);
                    k = r.Next(8);
                } while (T[j, k] != ÜresCella);

                T[j, k] = 'K';
            }
        }

        public void Fájlbaír()
        {
            StreamWriter streamWriter = new StreamWriter("tabla64.txt");
            //streamWriter.AutoFlush = true;
            for (int i = 1; i <= 64; i++)
            {
                Elhelyez(1);
                for (int k = 0; k < 8; k++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        streamWriter.Write(T[k, j]);
                    }
                    streamWriter.WriteLine();
                }
                streamWriter.WriteLine();
            }


            streamWriter.Close();
        }

        public void Megjelenít()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(T[i,j]);
                }
                Console.WriteLine();
            }
        }

        public bool ÜresOszlop(int oszlop)
        {
            for (int i = 0; i < 8; i++)
            {
                if (T[i, oszlop] == 'K')
                {
                    return false;
                }
            }

            return true;
        }

        public bool ÜresSor(int sor)
        {
            for (int i = 0; i < 8; i++)
            {
                if (T[sor, i] == 'K')
                {
                    return false;
                }
            }

            return true;
        }

    }
}
