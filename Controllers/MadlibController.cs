//Pedro Castaneda
//10-25-2022
//Madlib - Endpoint
//Create a controll with an enpoint for Madlib function that takes input from user (words) and uses them in a story and returns the story with their words included.
//Peer Review by; 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace castanedaPMadlibEndpoint.Controllers
{
    [Route("[controller]")]
    public class MadlibController : Controller
    {
       [HttpGet]
       [Route("Madlib/{adj1}/{adj2}/{noun1}/{noun2}/{noun3}/{noun4}/{noun5}/{verb1}/{verb2}/{verb3}/{verb4}/{adverb}")]
       public string Madlib(string adj1, string adj2, string noun1, string noun2, string noun3, string noun4, string noun5, string verb1, string verb2, string verb3, string verb4, string adverb)
       {
            bool word1 = adj1.All(Char.IsLetter);
            bool word2 = adj2.All(Char.IsLetter);
            bool word3 = noun1.All(Char.IsLetter);
            bool word4 = noun2.All(Char.IsLetter);
            bool word5 = noun3.All(Char.IsLetter);
            bool word6 = noun4.All(Char.IsLetter);
            bool word7 = noun5.All(Char.IsLetter);
            bool word8 = verb1.All(Char.IsLetter);
            bool word9 = verb2.All(Char.IsLetter);
            bool word10 = verb3.All(Char.IsLetter);
            bool word11 = verb4.All(Char.IsLetter);
            bool word12 = adverb.All(Char.IsLetter);
            string result = $"Once upon a time there was a {adj1} {noun1} who liked {verb1} trees. \nAfter a long day from {verb2}, it sat down and took off it's {noun2}. \nIt {adverb} {verb3} over to the kitchen to grab a {noun3} from the fridge, tripped over a {noun4} and hit its head on the corner of the {noun5}. \nIt never went back to {verb4} ever again because it was {adj2}. THE END.";
            if(!word1 || !word2 || !word3 || !word4 || !word5 || !word6 || !word7 || !word8 || !word9 || !word10 || !word11 || !word12)
            {
                result = "Invalid Entry";
            }
            return result;
       }
    }
}