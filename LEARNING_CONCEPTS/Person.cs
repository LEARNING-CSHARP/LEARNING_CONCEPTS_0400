namespace LEARNING_CONCEPTS
{
	public class Person
	{
		public int Age;
		public string FullName;

		public void ShowInfo()
		{
			// Solution (1)
			//string strMessage =
			//	string.Format("I'm {0} and {1} years old.", FullName, Age);

			//System.Console.WriteLine(strMessage);
			// /Solution (1)

			// Solution (2)
			System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
			// /Solution (2)
		}
	}
}
