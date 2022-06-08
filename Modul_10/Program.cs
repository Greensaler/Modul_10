using System;

namespace Modul_10
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();
		}
		public class Calculator
		{
			private double firstValue, secondValue;
			private string action;

			public Calculator()
			{
				GetSetCalc();
			}
			private void GetSetCalc()
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
}

