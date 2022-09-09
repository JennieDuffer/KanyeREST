using Newtonsoft.Json.Linq;

for (int i = 0; i < 5; i++)
{
    var client = new HttpClient();

    var kanyeURL = "https://api.kanye.rest/";
    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
    var kanyeObject = JObject.Parse(kanyeResponse);
    Console.WriteLine($"Kanye: {kanyeObject["quote"]}");

    var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
    var ronResponse = client.GetStringAsync(ronURL).Result;
    var ronObject = JArray.Parse(ronResponse);
    Console.WriteLine($"Ron:{ronObject[0]}");
}







