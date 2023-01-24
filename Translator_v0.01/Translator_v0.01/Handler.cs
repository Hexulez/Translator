﻿using Microsoft.Win32.SafeHandles;
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
    internal static class Handler
    {
        static string tester = "";
        static string API = "";
        static string language = Variables.Language;
        private static void caller(string feed, string language)
        {
            Console.WriteLine(Variables.Language);
            //string language = "";
            tester = feed;
            //FeedControl.CheckFeed(feed);
            if (feed == "F8")
            {
                language = "Translate to " + language + ": ";
                FeedControl.TranslateAsync(language, true);
            }
            else if (feed == "F7")
            {
                
                language = "Translate to finnish: ";
                FeedControl.TranslateAsync(language, false);
                //FOCUS.FocusProcess("Translator_v0.01");
            }
            else if (feed == "F9")
            {
                string choice = OPTIONS.Settings();
            }
        }
        
        internal static void Handle(string feed)
        {
            
            caller(feed, language);
        }

        internal static void CheckOptions (string choice) 
        {
            if (choice == "")
            {
                return;
            }
            else if (choice.Substring(0, 3) == "lan")
            {
                language = choice.Substring(3);
                Variables.Language = language;
            }
            else if (choice.Substring(0, 3) == "API")
            {
                API= choice.Substring(3);
                API_KEY.ChangeAPI(API);
            }


            
        }
    }
}