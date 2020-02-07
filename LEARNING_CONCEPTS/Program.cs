namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			// **********
			//Person p;

			//p.Age = 20; // Compile Error!
			// **********

			// **********
			//Person p;
			//p = new Person();

			//p.ShowInformation();
			// **********

			// **********
			//Person p = new Person();

			//p.ShowInformation();
			// **********

			// **********
			//Person p = new Person();

			//p.Age = 20;
			//p.FullName = "Ali Reza Alavi";

			//p.ShowInformation();
			// **********

			// **********
			//Person p1;
			//p1 = new Person();

			//p1.Age = 20;
			//p1.FullName = "Ali Reza Alavi";

			//p1.ShowInformation();

			//Person p2;
			//p2 = new Person();

			//p2.Age = 30;
			//P2.FullName = "Sara Ahmadi";

			//p2.ShowInformation();
			// **********

			// **********
			// کدام دستور ذیل اضافی می‌باشد
			// **********

			// **********
			//Person p1;
			//p1 = new Person();

			//p1.Age = 20;
			//p1.FullName = "Ali Reza Alavi";

			//p1.ShowInformation();

			//Person p2;
			//p2 = new Person();

			//p2 = p1;

			//p2.Age = 30;

			// دستور ذیل چه متنی را چاپ می‌کند
			//p1.ShowInformation();
			// **********

			// **********
			//Person p1;
			//p1 = new Person();

			//p1.Age = 20;
			//p1.FullName = "Ali Reza Alavi";

			//p1.ShowInformation();

			//Person p2;
			//p2 = p1;

			//p2.Age = 30;

			//p1.ShowInformation();
			// **********

			// **********
			//Person p1;
			//p1 = new Person();

			//p1.Age = 20;
			//p1.FullName = "Ali Reza Alavi";

			//p1.ShowInformation();

			//Person p2;
			//p2 = p1;

			//p2.Age = 30;

			//p1.ShowInformation();

			//p2 = null;

			//p2.Age = 40; // Runtime Error!
			//p2.ShowInformation(); // Runtime Error!
			// **********

			// **********
			// سوال: در کد ذیل چند شیء داریم؟

			//person p1 = new Person();

			//person p2 = p1;
			//person p3 = p1;
			//person p4 = p1;
			// **********

			// **********
			Person p = new Person();
			p.Age = 20;
			p.FullName = "Ali Reza Alavi";
			p.ShowInformation();

			IncreasePersonAge(p);

			p.ShowInformation();
			// **********

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}

		public static void IncreasePersonAge(Person person)
		{
			person.Age++;
		}
	}
}
