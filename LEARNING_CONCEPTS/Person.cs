namespace LEARNING_CONCEPTS
{
	public class Person
	{
		public int Age;

		public string FullName;

		public void ShowInformation()
		{
			//System.Console.WriteLine
			//	($"I'm { FullName } and { Age } years old.");

			string result =
				$"I'm { FullName } and { Age } years old.";

			System.Console.WriteLine(result);
		}
	}
}
