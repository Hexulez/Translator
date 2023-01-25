using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Translator_v0._01
{
    
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Console.WriteLine("This app is made by Henry Juhola <3");
            Console.WriteLine("Press F8 to translate text you already write");
            Console.WriteLine("Press F9 to settings");
            Console.WriteLine("");
            Console.WriteLine("beta feature:");
            Console.WriteLine("Select something and press F7 to translate finnish");
            starter();


        }

        static async void starter()
        {
            await API_KEY.CheckAPI();
            KeyHook.Hooker();
        }
    }
}
