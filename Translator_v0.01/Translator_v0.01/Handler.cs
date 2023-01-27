using Microsoft.Win32.SafeHandles;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Translator_v0._01
{
//handle different key press
    internal static class Handler
    {
        static string tester = "";
        static string API = "";
        static string language = Properties.Settings.Default.Translator_language; //get  preset language 

        private static void caller(string feed, string language) //call the feedcontrol
        {
            
            tester = feed;
            
            if (feed == "F8") //after this choice: copy text and paste new text as chosen language
            {
                language = Properties.Settings.Default.Translator_language; //get preset language
                language = "Translate to " + language + ": ";
                FeedControl.TranslateAsync(language, true); //call feedcontrol what is control of text what must translate.
            }
            else if (feed == "F7") // after this choice: translate to console window
            {
                
                language = "Translate to finnish: ";
                FeedControl.TranslateAsync(language, false); //call feedcontrol what is control of text what must translate.
                
            }
            else if (feed == "F9") //after this choice: going to options
            {

                string choice = OPTIONS.Settings();
                CheckOptions(choice);
            }
        }
        
        internal static void Handle(string feed)
        {
            
            caller(feed, language);
        }

        internal static void CheckOptions (string choice)  //handle answer from options. 
        {
            if (choice == "")
            {
                return;
            }
            else if (choice.Substring(0, 3) == "lan")
            {
                Console.WriteLine("testi");
                string change = choice.Substring(4);
                Console.WriteLine (change);
                Properties.Settings.Default.Translator_language  = change;
                Properties.Settings.Default.Save();
            }
            else if (choice.Substring(0, 3) == "API")
            {
                API= choice.Substring(3);
                API_KEY.ChangeAPI(API);
            }


            
        }
    }
}
