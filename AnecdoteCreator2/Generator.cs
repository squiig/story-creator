using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SentencePartsLibrary;

namespace AnecdoteCreator2
{
    public static class Generator
    {
        private static Random r = new Random();

        public static string GetNewSentence()
        {
            string sentence = "";

            if (r.NextDouble() < .2d)
            {
                sentence = $"\"{ GetPart() }\"  - { SubjectsLib.GetRandom() }, { GetRandomDate() }\n";
            }
            else sentence = $"{ GetPart() + MaybeAddSomething() }\n";

            return sentence;
        }

        private static string GetRandomDate()
        {
            string year = (1900 + r.Next(200)).ToString();
            string month = (1 + r.Next(12)).ToString();
            string day = r.Next(32).ToString();

            if (int.Parse(month) < 10) month = "0" + month;
            if (int.Parse(day) < 10) day = "0" + day;

            return $"{ year }-{ month }-{ day }";
        }

        private static string MaybeAddSomething()
        {
            string[] strings = new string[]
            {
                $", but { GetPart() }.",
                $", because { GetPart() }.",
                "?",
                "!",
                ". Really?",
                ", yay!",
                ", because I'm Batman!",
                $" and says \"{ GetPart() }.\"",
                ", but that doesn't matter.",
                "...",
                ". No shit.",
                $", oh well, { GetPart() }.",
                ". Wow!",
                ". Right...",
                ". That's so unexpected.",
                $", but actually { GetPart() }.",
                $", but this is false, because { GetPart() }.",
                $", that's why { GetPart() }.",
                "."
            };

            return strings[r.Next(strings.Length)];
        }

        private static string GetPart()
        {
            return $"{ SubjectsLib.GetRandom() } { VerbsLib.GetRandom() } { (r.NextDouble() < .1d ? SubjectsLib.GetRandom() : ObjectsLib.GetRandom())/* + MaybeAddSomething()*/ }";
        }
    }
}
