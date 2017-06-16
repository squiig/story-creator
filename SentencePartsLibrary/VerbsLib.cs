using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentencePartsLibrary
{
    public class VerbsLib
    {
        private static Random r = new Random();

        public static string[] GetList()
        {
            return new string[]
            {
                "throws",
                "receives",
                "eats",
                "drinks",
                "uses",
                "kills",
                "wrecks",
                "gives",
                "goes to",
                "discovers",
                "plays",
                "makes",
                "searches",
                "chews on",
                "thinks about",
                "smokes",
                "loves",
                "has",
                "beats",
                "is",
                "dirties",
                "looks at",
                "spies on",
                "destroys",
                "walks in at",
                "visits",
                "rings the bell at",
                "takes a picture of",
                "terrorises",
                "wastes",
                "punches",
                "hits",
                "meets",
                "votes on",
                "buys",
                "shits",
                "bombs",
                "questions",
                "films",
                "pays for"
            };
        }

        public static string GetRandom()
        {
            return GetList()[r.Next(GetList().Length)];
        }
    }
}
