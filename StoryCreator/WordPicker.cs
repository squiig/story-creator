using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace StoryCreator
{
    public enum WordType
    {
        Subject = 0,
        Object,
        Verb,
        Addition
    }

    public static class WordPicker
    {
        private static Random m_Random = new Random();

        public static string Pick(WordType wordType)
        {
            string[] subjects = null;

            try { subjects = File.ReadAllLines($@".\{ wordType.ToString().ToLower() }_list.txt"); }
            catch (FileNotFoundException e) { Console.WriteLine($"Error at { e.Source }, message: { e.Message }"); }

            if (subjects == null)
                return null;

            string result = subjects[m_Random.Next(subjects.Length)];

            if (wordType == WordType.Addition)
                result = result.Replace("^", $"{ Generator.GetPart() }");

            return result;
        }
    }
}
