using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace gpt_3_example_v0._3
{
//Make GPT-3 Call
    internal class GPT_CALL
    {
        internal static string Call_GPT(string prompt)
        {

            //call the open ai
            var answer = callOpenAI(100, prompt, "text-davinci-003", 0.3, 1, 0, 0);
            return answer;
        }

        private static string callOpenAI(int tokens, string input, string engine,
          double temperature, int topP, int frequencyPenalty, int presencePenalty)
        {
            var openAiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY", EnvironmentVariableTarget.User);
            if (string.IsNullOrEmpty(openAiKey))
            {
                return "OpenAI API Key not set";
            }

            var apiCall = "https://api.openai.com/v1/engines/" + engine + "/completions";

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), apiCall))
                    {
                        request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + openAiKey);
                        request.Content = new StringContent("{\n  \"prompt\": \"" + input + "\",\n  \"temperature\": " +
                                                            temperature.ToString(CultureInfo.InvariantCulture) + ",\n  \"max_tokens\": " + tokens + ",\n  \"top_p\": " + topP +
                                                            ",\n  \"frequency_penalty\": " + frequencyPenalty + ",\n  \"presence_penalty\": " + presencePenalty + "\n}");

                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                        var response = httpClient.SendAsync(request).Result;
                        if (!response.IsSuccessStatusCode)
                        {
                            return "OpenAI API call failed with status code:" + response.StatusCode;
                        }
                        var json = response.Content.ReadAsStringAsync().Result;

                        dynamic dynObj = JsonConvert.DeserializeObject(json);

                        if (dynObj != null)
                        {
                            string final = dynObj.choices[0].text.ToString();
                            final = final.Trim();
                            return final;
                        }
                        else
                        {
                            return "OpenAI API returned null response";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine("Error Occured:" + ex.Message);
                return "Error Occured: please check logs for more details";
            }
        }



    }



}

