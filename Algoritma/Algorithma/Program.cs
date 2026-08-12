using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetDragon(10, 6, 3, 5);
        }
        static void GetDragon(int swords, int archers, int mages, int healers)
        {
            int[] rem = { swords, archers, mages, healers };
            string[] names = { "swordsmen", "archers", "mages", "healers" };

            int total = swords + archers + mages + healers;
            int dragon = 1;

            while (total > 0)
            {
                int seats = Math.Min(5, total);
                int[] team = new int[4];

                for (int i = 1; seats > 0; i++)
                {
                    for (int j = 0; j < 4 && seats > 0; j++)
                    {
                        if (rem[j] > 0 && team[j] < i)
                        {
                            team[j]++;
                            rem[j]--;
                            seats--;
                            total--;
                        }
                    }
                }

                Console.WriteLine($"Dragon {dragon}: {team[0]} {names[0]}, {team[1]} {names[1]}, {team[2]} {names[2]}, {team[3]} {names[3]}");
                dragon++;
            }
        }
    }
}
