using Newtonsoft.Json.Linq;
using System.Net.Http;

// See https://aka.ms/new-console-template for more information


//API's depends on two different structures
//1) Objects -- curly braces {} -- unordered collection of values (99%* of JSON parsers do not maintain the order of objects)
//2) Arrays -- square brackets [] --ordered collection of values ( the order of elements in JSON arrays is preserved.)

//Stateless: Session state is entirely on the client.
//The client keeps hold of the information and sends a pre-packaged request/series of packets
//to the server. Nothing is stored on the server.

//API-- a means for two pieces of software to communicate with each other. It doesn't matter if 
// it's a console application, a browser, a desktop application, mobile application, etc-- they can all use an API


//Need NewtonSoft nuget packet to parse out objects

//in summary: Making a request=--> hit the URL endpoint with the proper verb,
//and you will get back the response in JSON format


var client = new HttpClient();

//KANYE QUOTE
Console.WriteLine("What Kanye says: ");
var url = "https://api.kanye.rest";
var response = client.GetStringAsync(url).Result;
Console.WriteLine(response);

//RON SWANSON
Console.WriteLine("What Ron says: ");
var url2 = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
var response2 = client.GetStringAsync(url2).Result;
Console.WriteLine(response2);

//
Console.WriteLine("What Chuck does: ");
var url3 = "https://api.chucknorris.io/jokes/random";
var response3 = client.GetStringAsync(url3).Result;
Console.WriteLine(response3);


//you must PARSE out the chuck norris quote to get the value you want
//parsing requires installing the Newtonsoft nuget package
//var response3Parsed = JObject.Parse(response3).GetValue("result").ToString().Replace('{', ' ').Replace('}', ' ').Trim();

//var gettingResult = response3.GetValue("Result").ToString();


//var formattedResponse = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

//Console.WriteLine(formattedResponse);

