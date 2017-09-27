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
		PostPart,
		PrePart
	}

	public static class WordPicker
	{
		private static Random m_Random = new Random();

		public static string Pick(WordType wordType)
		{
			string[] elements = null;

			try
			{
				elements = File.ReadAllLines($@".\sclib\{ wordType.ToString().ToLower() }_list.txt");
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine($"Error at { e.Source }, message: { e.Message }");
			}

			if (elements == null)
			{
				return null;
			}

			string result = "#";

			while (result.StartsWith("#"))
			{
				result = elements[m_Random.Next(elements.Length)];
			}

			if (wordType == WordType.PostPart)
			{
				result = result.Replace("^", $"{ Generator.GetPart() }");
			}

			return result;
		}
	}
}