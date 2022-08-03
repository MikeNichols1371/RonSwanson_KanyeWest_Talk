
using Newtonsoft.Json.Linq;

var client = new HttpClient();
var kanyeURL = "https://api.kanye.rest";
var ronSwansonUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

for (int i = 0; i < 5; i++)
{
    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
    var ronSwansonResponse = client.GetStringAsync(ronSwansonUrl).Result;

    var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
    var ronSwansonQuote = JArray.Parse(ronSwansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

    Console.WriteLine($"Kanye West: {kanyeQuote}");
    Console.WriteLine($"Ron Swanson: {ronSwansonQuote}");
    Console.WriteLine();
    
}



