using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Translator_v0._01
{
    internal class API_KEY
    {
        
        internal static async Task CheckAPI()
        {
            //Console.WriteLine(System.Environment.GetEnvironmentVariable("OPENAI_API_KEY", EnvironmentVariableTarget.User));

            if (System.Environment.GetEnvironmentVariable("OPENAI_API_KEY", EnvironmentVariableTarget.User) == null)
            {
                while (true)
                {

                    Console.WriteLine("Anna OpenAI API-key");
                    string apiKey = Console.ReadLine();
                    if (apiKey != "" && apiKey.Length > 8)
                    {
                        ChangeAPI(apiKey);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Error with key");
                    }
                }
            }
            

            

            
        }
                
        internal static void ChangeAPI(string apiKey)
        {
            System.Environment.SetEnvironmentVariable("OPENAI_API_KEY", apiKey, EnvironmentVariableTarget.User);
            Console.WriteLine("Thanks");
        }  
        
    }
}
