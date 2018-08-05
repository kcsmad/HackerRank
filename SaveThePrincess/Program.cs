using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrincess
{
    class Program
    {
        static void displayPathtoPrincess(int n, String[] grid)
        {
            int botX = 0;
            int botY = 0;
            int princessX = 0;
            int princessY = 0;

            for (int line = 0; line < n; line++)
            {
                if (grid[line].Contains("m"))
                {
                    botX = line;
                    botY = grid[line].IndexOf('m');
                }
                else if (grid[line].Contains("p"))
                {
                    princessX = line;
                    princessY = grid[line].IndexOf('p');
                }
            }

            int distanceX = princessX - botX;
            int distanceY = princessY - botY;

            for (int walk = 0; walk < Math.Abs(distanceX); walk++)
            {
                if (botX < princessX)
                {
                    Console.WriteLine("DOWN");
                }
                else
                {
                    Console.WriteLine("UP");
                }
            }

            for (int walk = 0; walk < Math.Abs(distanceY); walk++)
            {
                if (botY < princessY)
                {
                    Console.WriteLine("RIGHT");
                }
                else
                {
                    Console.WriteLine("LEFT");
                }
            }

            Console.ReadLine();
        }

        static void Main(String[] args)
        {
            int m;

            m = 5;

            String[] grid = new String[5];

            grid[0] = "-----";
            grid[1] = "-----";
            grid[2] = "--m--";
            grid[3] = "-----";
            grid[4] = "--p--";

            //for (int i = 0; i < m; i++)
            //{
            //    grid[i] = Console.ReadLine();
            //}

            displayPathtoPrincess(m, grid);
        }
    }
}
