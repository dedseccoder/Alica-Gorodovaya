using System;

namespace Block2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите х: ");
			var x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите y: ");
			var y = Convert.ToInt32(Console.ReadLine());
			if (x > y)
			{
				Console.WriteLine("x > y");
			}
			else if(x == y)
			{
				Console.WriteLine("x = y");
			}
			else if(x < y)
			{
				Console.WriteLine("x < y");
			}
			Console.ReadLine();
		}
	}
}
