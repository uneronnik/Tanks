using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] T34Tanks = new Tank[5];
            for(int i = 0; i < T34Tanks.Length; i++)
            { 
                T34Tanks[i] = new Tank("T34");
                Console.WriteLine(T34Tanks[i].dataToString());
            }

            Tank[] PanteraTanks = new Tank[5];
            for (int i = 0; i < PanteraTanks.Length; i++)
            {
                PanteraTanks[i] = new Tank("Pantera");
                Console.WriteLine(PanteraTanks[i].dataToString());
            }

            int T34Wins = 0;
            int PanteraWins = 0;

            for (int i = 0; i < T34Tanks.Length; i++)
            {
                if (T34Tanks[i] * PanteraTanks[i] == true)
                    T34Wins++;
                else
                    PanteraWins++;
            }

            if (T34Wins > PanteraWins)
                Console.WriteLine("Танки T34 победили!");
            else
                Console.WriteLine("Танки Pantera победили!");
            Console.ReadKey();
        }
    }
}
