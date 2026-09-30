using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppg1c
{
    public class Uppg1c
    {
        public static int Countpairs(int[] sortedarr)
        {
            int pairs = 0;
            int count = 1;

            for (int i = 1; i < sortedarr.Length; i++) // Börja från index 1 eftersom vi jämför med föregående element
            {
                if (sortedarr[i] == sortedarr[i - 1]) // Om det nuvarande elementet är lika med det föregående, öka räknaren
                {
                    count++;
                }
                else // Om det nuvarande elementet är olika, beräkna antalet par för den nuvarande gruppen och återställ räknaren
                {
                    pairs += count * (count - 1) / 2; // Beräkna antalet par för den nuvarande gruppen
                    count = 1;
                }
            }

            // Räkna även sista gruppen
            pairs += count * (count - 1) / 2;

            return pairs;
        }

        public static void Main(string[] args)
        {
            int[] sortedarr = { 1,1,1,2,3,3};
            int result = Countpairs(sortedarr);
            Console.WriteLine("Antal par: " + result);
        }
    }
}
