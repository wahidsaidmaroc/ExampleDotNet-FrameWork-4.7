using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Casablanca");
            keyValuePairs.Add(2, "Rabat");
 

            foreach (var item in keyValuePairs)
            {
                Console.Write("Clé : {0}", item.Key, item.Value);
            }


            var listeVille = new Dictionary<string, string>();

            listeVille.Add("MA", "Casa, Fes, Rabat");
            listeVille.Add("ma", "Casa, Fes, Rabat");
            listeVille.Add("FR", "Paris , nante");

            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "Un"); //adding a key/value using the Add() method
            numberNames.Add(2, "Deux");
            numberNames.Add(3, "Cinq");

            //The following throws run-time exception:
            //key already added.
            //numberNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);



            //Access Dictionary Elements

            var citiesName = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine(citiesName["UK"]); //prints value of UK key
            Console.WriteLine(citiesName["USA"]);//prints value of USA key
                                             //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if (citiesName.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if (citiesName.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < citiesName.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }



            #region "Example: Update Dictionary Elements"

                var citiesU = new Dictionary<string, string>(){
        {"UK", "London, Manchester, Birmingham"},
        {"USA", "Chicago, New York, Washington"},
        {"India", "Mumbai, New Delhi, Pune"}
    };

            citiesU["UK"] = "Liverpool, Bristol"; // update value of UK key
            citiesU["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                       //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

                if (citiesU.ContainsKey("France"))
                {
                    cities["France"] = "Paris";
                }

            #endregion

            #region "Example: Remove Dictionary Elements"


            var citiesR = new Dictionary<string, string>(){
                    {"UK", "London, Manchester, Birmingham"},
                    {"USA", "Chicago, New York, Washington"},
                    {"India", "Mumbai, New Delhi, Pune"}
                };

            citiesR.Remove("UK"); // removes UK 
                                 //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (citiesR.ContainsKey("France"))
            { // check key before removing it
                citiesR.Remove("France");
            }

            citiesR.Clear(); //removes all elements


            #endregion

        }
    }
}
