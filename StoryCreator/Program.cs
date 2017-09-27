using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryCreator
{
	internal class Program
	{
		public const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		private static void Main(string[] args)
		{
			Console.Title = "Story Creator - by Stan Graafmans";
			Console.SetWindowSize(120, 40);

			while (true)
			{
				StringBuilder sentence = new StringBuilder(Generator.GetNewSentence());

				if (sentence[0] == '\"')
				{
					sentence[1] = char.ToUpper(sentence[1]);
				}
				else
				{
					sentence[0] = char.ToUpper(sentence[0]);
				}

				for (int i = 0; i < sentence.Length; i++)
				{
					if (i > 1)
					{
						if (!(ALPHABET.Contains(sentence[i - 1]) || sentence[i - 1] == ','
							|| ALPHABET.Contains(sentence[i - 2]) || sentence[i - 2] == ','))
						{
							sentence[i] = char.ToUpper(sentence[i]);
						}
					}
				}

				Console.WriteLine(sentence.ToString());

				Console.ReadKey(true);
			}
		}
	}
}