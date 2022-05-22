using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
		public int AverageHeight { get; private set; }
		public string Setting { get; private set; }

		public bool IsAsleep { get; private set; } = false;



		public Cat(int averageHeight, string setting)
		{
			AverageHeight = averageHeight;
			Setting = setting;

		}

		public void GoToSleep()
        {
			IsAsleep = true;
        }
		public void WakeUp()
        {
			IsAsleep = false;
        }
		public abstract string Eat();
        
        
	}
}
