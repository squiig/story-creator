using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryCreator
{
	public static class Generator
	{
		private static Random m_Random = new Random();

		public static string GetNewSentence()
		{
			string sentence = GetPart();

			if (m_Random.NextDouble() < .2d)
			{
				sentence = $"\"{ sentence }\"  - { WordPicker.Pick(WordType.Subject) }, { GetRandomDate() }";
			}
			else
			{
				sentence = $"{ sentence }{ WordPicker.Pick(WordType.PostPart) }";

				if (m_Random.NextDouble() < .2d)
					sentence = $"{ WordPicker.Pick(WordType.PrePart) } { sentence }";
			}

			return $"{ sentence }\n";
		}

		private static string GetRandomDate()
		{
			string year = (1900 + m_Random.Next(200)).ToString();
			string month = (1 + m_Random.Next(12)).ToString();
			string day = m_Random.Next(32).ToString();

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
			return $"{ WordPicker.Pick(WordType.Subject) } { WordPicker.Pick(WordType.Verb) } { WordPicker.Pick((m_Random.NextDouble() < .1d ? WordType.Subject : WordType.Object)) }";
		}
	}
}