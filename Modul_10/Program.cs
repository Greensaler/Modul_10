using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Modul_10
{


	class Program
	{
		static ILogger Logger { get; set; }
		static void Main(string[] args)
		{
			Logger = new Logger();
			var calculator1 = new Calculator1(Logger);
			var calculator2 = new Calculator2(Logger);
			var calculator3 = new Calculator3(Logger);

			calculator1.Work();
			calculator2.Work();
			calculator3.Work();

			Console.ReadLine();
		}

	}
	public interface ILogger
	{
		void Event(string message);
		void Error(string message);
	}
	public class Logger : ILogger
	{
		public void Error(string message)
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
		}

		public void Event(string message)
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine(message);
		}
	}
	public interface IWork
	{
		void Work();
	}
}

