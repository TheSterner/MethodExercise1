using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
	class Program
	{
		static void Main(string[] args)
		{

			Practice practice = new Practice();
			Console.WriteLine("Please pick a number between 1-50.");
			int userNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please pick another number between 1-50");
			int userNumber2 = Convert.ToInt32(Console.ReadLine());
			practice.Integers(userNumber, userNumber2);
			

		}
		

		
	}
}
