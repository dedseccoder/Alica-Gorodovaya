using System;

namespace Block1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите количество людей в бригаде: ");
			int people = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество часов: ");
			int hours = Convert.ToInt32(Console.ReadLine());

			var work = people / hours;

			Console.WriteLine("Занятость: " + work);
			Console.ReadLine();
		}
	}
}
