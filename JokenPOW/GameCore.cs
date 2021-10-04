using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPOW
{
    class GameCore
    {
        public static void Game()
        {
            Console.WriteLine("Welcome to the JokenPOW game.\r\n\r\n" +
                "Player 1, press 1 for rock, 2 for paper or 3 for scissors.\r\n");
            var p1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\r\nPlayer 2, press 1 for rock, 2 for paper or 3 for scissors.\r\n");
            var p2 = Int32.Parse(Console.ReadLine());

            if (p1 == p2)
            {
                Console.WriteLine("\r\nIt was a draw! Both players chose the same.");
            }
            else if (p1 == 1 && p2 == 2)
            {
                Console.WriteLine("\r\nPaper invoves Rock. Player 2 won!");
            }
            else if (p1 == 1 && p2 == 3)
            {
                Console.WriteLine("\r\nRock smashes scissors. Player 1 won!");
            }
            else if (p1 == 2 && p2 == 1)
            {
                Console.WriteLine("\r\nPaper invoves Rock. Player 1 won!");
            }
            else if (p1 == 2 && p2 == 3)
            {
                Console.WriteLine("\r\nScissors cuts paper. Player 2 won!");
            } 
            else if(p1 == 3 && p2 == 1)
            {
                Console.WriteLine("\r\nRock smashes scissors. Player 2 won!");
            }
            else if(p1 == 3 && p2 == 2)
            {
                Console.WriteLine("\r\nScissors cuts paper.Player 1 won!");
            }
            }

        }
    }

