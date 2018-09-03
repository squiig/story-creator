using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryCreator
{
	public static class Generator
	{
		private static Random _random = new Random();

		public static string GetNewSentence()
		{
			string sentence = GetPart();

			if (_random.NextDouble() < .2d)
			{
				sentence = $"\"{ sentence }\"  - { WordPicker.Pick(WordType.Subject) }, { GetRandomDate() }";
			}
			else
			{
				sentence = $"{ sentence }{ WordPicker.Pick(WordType.PostPart) }";

				if (_random.NextDouble() < .2d)
					sentence = $"{ WordPicker.Pick(WordType.PrePart) } { sentence }";
			}

			return $"{ sentence }\n";
		}

		private static string GetRandomDate()
		{
			string year = (1900 + _random.Next(200)).ToString();
			string month = (1 + _random.Next(12)).ToString();
			string day = _random.Next(32).ToString();

			if (int.Parse(month) < 10)
			{
				month = "0" + month;
			}

			if (int.Parse(day) < 10)
			{
				day = "0" + day;
			}

			return $"{ year }-{ month }-{ day }";
		}

		public static string GetPart()
		{
			return $"{ WordPicker.Pick(WordType.Subject) } { WordPicker.Pick(WordType.Verb) } { WordPicker.Pick((_random.NextDouble() < .1d ? WordType.Subject : WordType.Object)) }";
		}
	}
}