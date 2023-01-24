using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator_v0._01
{
    internal class OPTIONS
    {
        internal static string Settings()
        {
            FOCUS.FocusProcess("Translator_v0.01");
            while (true)
            {
                string menuChoice = "";
                MenuText();
                menuChoice = Choose();
                if (menuChoice == "exit")
                {
                    return "";
                }
                else
                {
                    return menuChoice;
                }

            }
        }

        private static void MenuText()
        {
            Console.WriteLine("1. Change language");
            Console.WriteLine("2. Change API-Key");
            Console.WriteLine("3. Exit");
            return;
        }

        private static string Choose()
        {
            string choice = "";
            
            string luku =  Console.ReadLine();
            if (luku == "1") 
            {
                Console.WriteLine("Enter the language you want to translate into.");
                choice = Console.ReadLine();
                return "lan " + choice;
            }
            
            else if (luku == "2")
            {
                Console.WriteLine("Give new API-Key");
                Console.ReadLine();
                return "API " +choice;
            }
            else
            {
                return "exit";
            }


        }

        


    }
}
