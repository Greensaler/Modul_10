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
			GetSetCalculator();
		}
		private void GetSetCalculator()
		{
			int i = 1;
		while (true)
			{
				Console.Clear();
				int j = i++;
				Logger.Event($"Калькулятор №{j} начал свою рботу");
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
					Logger.Error("Некорректный ввод числа");
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
							Logger.Error("Делить на ноль нельзя");
							Console.ReadLine();
							continue;
						}
						else
							Console.WriteLine($"Ответ:{firstValue / secondValue}");
						break;
					default:
						Logger.Error("Ошибка! Неизвестное действие!");
						break;
				}
				Logger.Event($"Калькулятор №{j} окончил свою рботу");
				Console.ReadLine();
			}
		}
	}
}
