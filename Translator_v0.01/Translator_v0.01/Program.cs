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
            Properties.Settings.Default.Save();


            starter();


        }

        static async void starter()
        {
            await API_KEY.CheckAPI();
            KeyHook.Hooker();
        }
    }
}
