using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Translator_v0._01
{
    //handle API_Key
    internal class API_KEY
    {
        //check if there is API-Key all ready
        internal static async Task CheckAPI()
        {
            
            if (System.Environment.GetEnvironmentVariable("OPENAI_API_KEY", EnvironmentVariableTarget.User) == null)
            {
                while (true)
                {

                    Console.WriteLine("Give OpenAI API-key");
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
        
        //change API-Key
        internal static void ChangeAPI(string apiKey) 
        {
            System.Environment.SetEnvironmentVariable("OPENAI_API_KEY", apiKey, EnvironmentVariableTarget.User);
            Console.WriteLine("Thanks");
        }

        //remove API-Key
        internal static void RemoveAPI()
        {
            System.Environment.SetEnvironmentVariable("OPENAI_API_KEY", null, EnvironmentVariableTarget.User);
        }
    }
}
