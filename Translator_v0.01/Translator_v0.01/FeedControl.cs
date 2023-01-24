using gpt_3_example_v0._3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator_v0._01
{
    public static class FeedControl
    {
        //private static bool all = false;        
        private static string sentence = "";
        public static string Sentence
        {
            get { return sentence; }
            set { sentence = value; }
            
        }
        
        public static async Task TranslateAsync(string language, bool all)
        {
            
            await TEXT_COPY.CopyText(all);
            sentence = (language + Clipboard.GetText());
            string answer = GPT_CALL.Call_GPT(sentence);
            //Console.WriteLine(Sentence);
            //Console.WriteLine(answer);
            
            sentence = "";
            if (all == false)
            {
                FOCUS.FocusProcess("Translator_v0.01");
                Console.WriteLine(sentence);
                Console.WriteLine(answer);
                Console.WriteLine();
                
            }
            else
            {
                TEXT_REPLACE.Replace(answer);
            }
            

        }

        //public bool Activate();

        /*
        public static void CheckFeed(string feed) 
        {
            if (feed == "Return")
            {
                //Console.WriteLine(Sentence);

                //TEXT_REPLACE.Replace(sentence);
                //sentence = "";
                //????
            }
            else if (feed == "Back")
            {
                if (sentence.Length> 0)
                {
                    //poista kirjain
                    sentence.Remove(sentence.Length - 1, 1);
                }

            }
            else if (feed == "F8")
            {
                //string answer = sentence;
                string answer = GPT_CALL.Call_GPT(sentence);
                TEXT_REPLACE.Replace(answer);
                //Console.Write(Sentence);
                sentence = "";
            }
            else if (feed == "Space")
            {
                sentence += " ";



            }
            else if (Regex.IsMatch(feed, @"^[A-Z]") && feed.Length == 1)
            {


                sentence += feed;

            }
            
            else if (feed == "Oemtilde")
            {
                sentence += "Ö";
            }
            else if (feed == "Oem7")
            {
                Sentence += "Ä";
            }

            else if (feed == "Oem6")
            {
                sentence+= "Å";
            }
            else
            {

            }
            Console.Write(feed);
            return;
        }
        */
    }
}
