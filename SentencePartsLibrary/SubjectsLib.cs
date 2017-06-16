using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentencePartsLibrary
{
    public class SubjectsLib
    {
        private static Random r = new Random();

        public static string[] GetList()
        {
            return new string[]
            {
                "father",
                "mother",
                "uncle",
                "aunty",
                "grandma",
                "grandpa",
                "he",
                "she",
                "it",
                "that stranger",
                "that man",
                "that woman",
                "that clown",
                "that hobo",
                "everyone",
                "that king",
                "that queen",
                "the government",
                "the lottery",
                "that priest"
            };
        }

        public static string GetRandom()
        {
            return GetList()[r.Next(GetList().Length)];
        }
    }
}
