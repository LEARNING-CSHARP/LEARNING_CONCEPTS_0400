namespace LEARNING_CONCEPTS
{
	public class Person
	{
		public int Age;
		public string FullName;

		public void ShowInfo()
		{
			System.Console.WriteLine($"I'm { FullName } and { Age } years old.");
		}
	}
}
