using System;

namespace Block3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите а: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите b: ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите c: ");
			int c = Convert.ToInt32(Console.ReadLine());

			var x = Math.Log(Math.Pow(Math.Cos(2 / a * b), 2) , Math.E);
			var y = Math.Pow(Math.Sin(a * b * c), 1 / 3) + Math.Pow(Math.E, -2 * a) - Math.Tan((Math.PI / 3) + a);

			Console.WriteLine("X = " + x + "\nY = " + y);
			Console.ReadLine();
		}
	}
}
