using System;

namespace Block4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите x: ");
			int x = Convert.ToInt32(Console.ReadLine());
			double F;

			if(x > 3)
			{
				F = Math.Log(Math.Abs((1 - Math.Pow(x, 2) + 2 * x) / (x + 3.5)), Math.E);
			}
			else
			{
				F = -x * Math.Pow(Math.Sin(x), 3);
			}
			Console.WriteLine("F(x) = " + F);
			Console.ReadLine();
		}
	}
}
