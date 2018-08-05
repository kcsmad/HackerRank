using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrincess2
{
    class Program
    {
        static void nextMove(int n, int r, int c, String[] grid)
        {
            int botX = r;
            int botY = c;
            int princessX = 0;
            int princessY = 0;

            for (int line = 0; line < n; line++)
            {
                if (grid[line].Contains("p"))
                {
                    princessX = line;
                    princessY = grid[line].IndexOf('p');
                }
            }

            if (botX != princessX)
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
            else
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


        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            String pos;
            pos = Console.ReadLine();
            String[] position = pos.Split(' ');
            int[] int_pos = new int[2];
            int_pos[0] = Convert.ToInt32(position[0]);
            int_pos[1] = Convert.ToInt32(position[1]);
            String[] grid = new String[n];
            for (int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine();
            }

            nextMove(n, int_pos[0], int_pos[1], grid);
        }
    }
}
