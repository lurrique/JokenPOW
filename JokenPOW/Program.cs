using System;

namespace JokenPOW
{
    class Program
    {
    static void Main(string[]args)
        {
            //next step is to try to transform this into a menu that can be accessed or returned to without having to end the application
            Console.WriteLine("Launch JokenPOW?\r\n\r\ny for yes\r\nn for no\r\n\r\n" +
                "Note: to read instructions press i.\r\n");
            char launch = Console.ReadKey(true).KeyChar;
            if (launch == 'y')
            {
                GameCore.Game();
            }
            else if (launch == 'n')
            {
                Environment.Exit(0);
            }
            else if (launch == 'i')
            {
                Items.Instructions();
            }
            else
            {
                Console.WriteLine("You did not typed a valid option");
            }
        }
    }
}

