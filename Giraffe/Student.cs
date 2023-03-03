using System;
namespace Giraffe
{
	public class Student
	{
		private string name;
		private string major;
		private double gpa;

		public Student()
		{
		}

		public Student(string name, string major, double gpa)
		{
			Name = name;
			this.major = major;
			this.gpa = gpa;

		}

		public bool HasHonours()
		{
			if (gpa >= 3.5) 
			{
				return true;
			}
			return false;
		}

		public string Name
		{
			get { return name; }
			set {
				if (value == "G" || value == "PG" || value == "PG-13")
				{
					this.Name = name;
				} else
				{
					this.name = "ERROR";
				}
			}
		}

		
	}
}

