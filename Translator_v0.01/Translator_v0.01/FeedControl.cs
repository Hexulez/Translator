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
//control and handle user feed
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

        
    }
}
