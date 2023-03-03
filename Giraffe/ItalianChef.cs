using System;
namespace Giraffe
{
	public class ItalianChef : Chef
	{

		public void MakeePasta()
		{
			Console.WriteLine("The chef makes pasta");
		}

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes a chicken parm");
        }
    }
}

