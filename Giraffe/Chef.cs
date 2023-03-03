using System;
namespace Giraffe
{
	public class Chef
	{
		public void MakeChicken()
		{
			Console.WriteLine("The chef makes a chicken");
		}

		public void MakeSalad()
		{
			Console.WriteLine("The chef makes a salad");
		}

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes a bbq ribs");
        }

    }
}

