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
            switch (r.Next(19))
            {
                case 0:
                    return $", but { GetPart() }.";
                case 1:
                    return $", because { GetPart() }.";
                case 2:
                    return "?";
                case 3:
                    return "!";
                case 4:
                    return ". Really?";
                case 5:
                    return ", yay!";
                case 6:
                    return ", because I'm Batman!";
                case 7:
                    return $" and says \"{ GetPart() }.\"";
                case 8:
                    return ", but that doesn't matter.";
                case 9:
                    return "...";
                case 10:
                    return ". No shit.";
                case 11:
                    return $", oh well, { GetPart() }.";
                case 12:
                    return ". Wow!";
                case 13:
                    return ". Right...";
                case 14:
                    return ". That's so unexpected.";
                case 15:
                    return $", but actually { GetPart() }.";
                case 16:
                    return $", but this is false, because { GetPart() }.";
                case 17:
                    return $", that's why { GetPart() }.";
                default:
                    return ".";
            }
        }

        private static string GetPart()
        {
            return $"{ SubjectsLib.GetRandom() } { VerbsLib.GetRandom() } { (r.NextDouble() < .1d ? SubjectsLib.GetRandom() : ObjectsLib.GetRandom())/* + MaybeAddSomething()*/ }";
        }
    }
}
