using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiárd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyók = new List<int>();
            Kezdés(golyók);
            int leeső;
            do
            {
                leeső = Leesik(golyók);

                Kiíró(golyók);
                Console.WriteLine();
            } while (leeső!=8);
          




           

            Console.ReadKey();
        }

        private static void Kiíró(List<int> golyók)
        {
            foreach (int golyó in golyók)
            {
                Console.Write($"{golyó} ");
                
            }
            
        }

        private static int Leesik(List<int> golyók)
        {
            Random gép = new Random();
            int szám = gép.Next(golyók.Count);
            golyók.Remove(golyók[szám]);
            Console.WriteLine($"Ez esett le {szám}");
            
            
            return golyók[szám];
        


        }

        private static void Kezdés(List<int> golyók)
        {
         
            for (int i = 1; i <= 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
