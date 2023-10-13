// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
var client = new HttpClient(); 
var request = new HttpRequestMessage 
{ Method = HttpMethod.Get,
    RequestUri = new Uri("https://alpha-vantage.p.rapidapi.com/query?interval=5min&function=TIME_SERIES_INTRADAY&symbol=MSFT&datatype=json&output_size=compact"), 
    Headers = { { "X-RapidAPI-Key", "1fabf68df4msh551f3c49435c2f9p1e6e61jsn9324140cea3a" }, { "X-RapidAPI-Host", "alpha-vantage.p.rapidapi.com" }, }, };
using 
(var response = await client.SendAsync(request))
{ response.EnsureSuccessStatusCode(); var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body); }

