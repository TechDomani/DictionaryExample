namespace DictionaryExample
{
	internal class Program
	{
		static void Main()
		{
			Frequency();			
		}

		private static void StudentDictionary()
		{
			Student bob = new("Bob", "Marley", new DateOnly(1950, 11, 10));
			bob.AddSubject("French");
			bob.AddSubject("Music");
			Console.WriteLine(bob.GetSubjects());

			Student bob2 = new("Bob", "Dylan", new DateOnly(1970, 10, 09));
			Student susie = new("Susie", "Smith", new DateOnly(1980, 03, 8));

			Dictionary<string, Student> studentDict = [];
			studentDict.Add(bob.FullName, bob);
			studentDict.Add(bob2.FullName, bob2);
			studentDict.Add(susie.FullName, susie);

			Console.WriteLine(studentDict["Bob Marley"].GetSubjects());
		}

		private static void Frequency()
		{
			List<string> pets = ["cat", "dog", "budgie", "rabbit", "fox", "dog", "cat", "cat", "cheetah", "rabbit", "dog"];
			Dictionary<string, int> petFrequency = [];
			foreach (string pet in pets)
			{
				if (!petFrequency.TryAdd(pet, 1))
				{
					petFrequency[pet] += 1;
				}
			}
			Console.WriteLine($"There are {petFrequency["dog"]} dogs");
		}
	}
}
