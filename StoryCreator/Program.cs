using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Story Creator - by Stan Graafmans";
            Console.SetWindowSize(120, 40);

            for (;;)
            {
                StringBuilder sentence = new StringBuilder(Generator.GetNewSentence());

                if (sentence[0] == '\"')
                    sentence[1] = char.ToUpper(sentence[1]);
                else sentence[0] = char.ToUpper(sentence[0]);

                Console.WriteLine(sentence.ToString());

                Console.ReadKey(true);
            }
        }

    }
}
