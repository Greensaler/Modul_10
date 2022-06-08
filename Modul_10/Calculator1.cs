using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Modul_10
{

	public class Calculator1 : IWork
	{
		private double firstValue, secondValue;
		private string action;
		ILogger Logger { get; }
		public Calculator1(ILogger logger)
		{
			Logger = logger;
		}
		public void Work()
		{
			Logger.Event("Calculator 1 начал свою рботу");
			Thread.Sleep(3000);
			Logger.Event("Calculator 1 окончил свою рботу");
		}
		private void GetSetCalculator()
		{
			while (true)
			{
				Console.Clear();
				try
				{
					Console.WriteLine("Введите число 1");
					firstValue = double.Parse(Console.ReadLine());

					Console.WriteLine("Введите число 2");
					secondValue = double.Parse(Console.ReadLine());
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("Некорректный ввод числа");
					Console.ReadLine();
					continue;
				}

				Console.WriteLine("Выберите операцию: '+' '-' '*' '/' ");
				action = Console.ReadLine();

				switch (action)
				{
					case "+":
						Console.WriteLine($"Ответ:{ firstValue + secondValue}");
						break;
					case "-":
						Console.WriteLine($"Ответ:{ firstValue - secondValue}");
						break;
					case "*":
						Console.WriteLine($"Ответ:{firstValue * secondValue}");
						break;
					case "/":
						if (secondValue == 0)
						{
							Console.WriteLine("На ноль делить нельзя");
							Console.ReadLine();
							continue;
						}
						else
							Console.WriteLine($"Ответ:{firstValue / secondValue}");
						break;
					default:
						Console.WriteLine("Ошибка! Неизвестное действие!");
						break;
				}
				Console.ReadLine();
			}
		}
	}
	public class Calculator2 : IWork
	{
		private double firstValue, secondValue;
		private string action;
		ILogger Logger { get; }
		public Calculator2(ILogger logger)
		{
			Logger = logger;
		}
		public void Work()
		{
			Logger.Event("Calculator 2 начал свою рботу");
			Thread.Sleep(3000);
			Logger.Event("Calculator 2 окончил свою рботу");
		}
		private void GetSetCalculator()
		{
			while (true)
			{
				Console.Clear();
				try
				{
					Console.WriteLine("Введите число 1");
					firstValue = double.Parse(Console.ReadLine());

					Console.WriteLine("Введите число 2");
					secondValue = double.Parse(Console.ReadLine());
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("Некорректный ввод числа");
					Console.ReadLine();
					continue;
				}

				Console.WriteLine("Выберите операцию: '+' '-' '*' '/' ");
				action = Console.ReadLine();

				switch (action)
				{
					case "+":
						Console.WriteLine($"Ответ:{ firstValue + secondValue}");
						break;
					case "-":
						Console.WriteLine($"Ответ:{ firstValue - secondValue}");
						break;
					case "*":
						Console.WriteLine($"Ответ:{firstValue * secondValue}");
						break;
					case "/":
						if (secondValue == 0)
						{
							Console.WriteLine("На ноль делить нельзя");
							Console.ReadLine();
							continue;
						}
						else
							Console.WriteLine($"Ответ:{firstValue / secondValue}");
						break;
					default:
						Console.WriteLine("Ошибка! Неизвестное действие!");
						break;
				}
				Console.ReadLine();
			}
		}
	}
	public class Calculator3 : IWork
	{
		private double firstValue, secondValue;
		private string action;
		ILogger Logger { get; }
		public Calculator3(ILogger logger)
		{
			Logger = logger;
		}
		public void Work()
		{
			Logger.Event("Calculator 3 начал свою рботу");
			Thread.Sleep(3000);
			Logger.Event("Calculator 3 окончил свою рботу");
		}
		private void GetSetCalculator()
		{
			while (true)
			{
				Console.Clear();
				try
				{
					Console.WriteLine("Введите число 1");
					firstValue = double.Parse(Console.ReadLine());

					Console.WriteLine("Введите число 2");
					secondValue = double.Parse(Console.ReadLine());
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("Некорректный ввод числа");
					Console.ReadLine();
					continue;
				}

				Console.WriteLine("Выберите операцию: '+' '-' '*' '/' ");
				action = Console.ReadLine();

				switch (action)
				{
					case "+":
						Console.WriteLine($"Ответ:{ firstValue + secondValue}");
						break;
					case "-":
						Console.WriteLine($"Ответ:{ firstValue - secondValue}");
						break;
					case "*":
						Console.WriteLine($"Ответ:{firstValue * secondValue}");
						break;
					case "/":
						if (secondValue == 0)
						{
							Console.WriteLine("На ноль делить нельзя");
							Console.ReadLine();
							continue;
						}
						else
							Console.WriteLine($"Ответ:{firstValue / secondValue}");
						break;
					default:
						Console.WriteLine("Ошибка! Неизвестное действие!");
						break;
				}
				Console.ReadLine();
			}
		}
	}

}
