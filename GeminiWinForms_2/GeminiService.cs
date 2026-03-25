using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class GeminiService
{
    private readonly string apiKey = "AIzaSyCON_k5zmKgLRU_yucZXWdR8And5CgYoYU";
    private readonly string url;

    public GeminiService()
    {
        url = $"https://generativelanguage.googleapis.com/v1/models/gemini-2.5-flash:generateContent?key={apiKey}";
    }

    public async Task<string> EnviarPrompt(string mensaje)
    {
        var request = new
        {
            contents = new[]
            {
                new
                {
                    parts = new[]
                    {
                        new { text = mensaje }
                    }
                }
            }
        };

        using (HttpClient client = new HttpClient())
        {
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            var result = await response.Content.ReadAsStringAsync();

            dynamic data = JsonConvert.DeserializeObject(result);

            if (data?.candidates != null && data.candidates.Count > 0)
            {
                return data.candidates[0]?.content?.parts?[0]?.text?.ToString() ?? "Sin respuesta";
            }
            else
            {
                return "Error: la API no devolvió datos";
            }




        }

    }
}