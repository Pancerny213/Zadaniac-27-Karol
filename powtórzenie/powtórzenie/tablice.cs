using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtórzenie
{
    public class Tablice
    {
        public void wyswietl()
        {
            Console.WriteLine("To jest plik z tablicami");
        }
        public int[] Tworzenie_Tablicy()
        {
            Console.WriteLine("Ile znaków ma mieć tablica");
            int dl = int.Parse(Console.ReadLine());

            int[] ints = new int[dl];
            
            for(int i=0; i<dl; i++)
            {
                Console.WriteLine("Podaj kolejny element");
                ints[i] = int.Parse(Console.ReadLine());
            }
            return ints;
        }
    }
}
