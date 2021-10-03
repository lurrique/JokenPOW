using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPOW
{
    class Items
    {
        public static void Instructions()
        {
            Console.WriteLine("This is a Rock, paper and scissors game. Initially, a first player will type:" +
                "\r\n1 for rock;\r\n2 for paper;\r\n3 for scissors.\r\nThen, the second player will do the same thing." +
                "\r\n\r\nNote: no player should be able to look at each other's choice.\r\n");
            //class should take the application back to the main menu after this message is shown

        }
        //next step is to try to build an event class that gathers both players choices and decides wich one is the winner
        //also it's important to try to build string classes for the messages so the GameCore.cs code gets more compact
    }
}
        


    

