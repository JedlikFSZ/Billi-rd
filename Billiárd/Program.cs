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

            foreach (int golyó in golyók)
            {
                Console.WriteLine(golyó);
            }

            Console.ReadKey();
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
