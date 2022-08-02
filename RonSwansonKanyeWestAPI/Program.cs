
using Newtonsoft.Json.Linq;

var client = new HttpClient();
var kanyeURL = "https://api.kanye.rest";
var ronSwansonUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
var ronSwansonResponse = client.GetStringAsync(ronSwansonUrl).Result;

var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
var ronSwansonQuote = JArray.Parse(ronSwansonResponse).ToString().Replace('[',' ').Replace(']', ' ');

Console.WriteLine(kanyeQuote);
Console.WriteLine(ronSwansonQuote);


