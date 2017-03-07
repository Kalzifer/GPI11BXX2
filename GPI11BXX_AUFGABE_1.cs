/*
 * Created by VIM
 * User: Frank Schmidt
 * Date: 06.03.2017
 * Time: 21:58
 */
using System;

namespace GPI11BXX_AUFGABE_1
{
	class Program
	{
        public static UInt64 ask_user_for_UInt64(string message)
		{
			UInt64 value;
			string user_content;
			do
			{
				Console.Write(message);
				user_content = Console.ReadLine();
			} while (!UInt64.TryParse(user_content, out value));

			return value;
		}

		public static  UInt64 lesson_a(UInt64 start, UInt64 stop)
		{
			UInt64 sum = start;
			for (UInt64 i = start + 1; i <= stop; i++)
			{
				sum += i;
			}
			return sum;
		}

		public static UInt64 lesson_b(UInt64 start, UInt64 stop)
		{
			UInt64 sum = 0;

			while (start <= stop)
			{
				sum += start;
				start++;	
			}
			return sum;
		}

		public static UInt64 lesson_c(UInt64 start, UInt64 stop)
		{
			UInt64 sum = 0;
			do
			{
				sum += start;
				start++;
			} while (start <= stop);
			return sum;
		}

		public static UInt64 lesson_d(UInt64 start, UInt64 stop)
		{
			UInt64 sum = start;
			start++;
			return calc(start, stop, sum);
		}
		public static UInt64 calc(UInt64 start, UInt64 stop, UInt64 sum)
		{
			if (start > stop)
			{
				return sum;
			}
			sum += start;
			start++;
			return calc(start, stop, sum);
		}

		public static void Main(string[] args)
		{
			UInt64 start;
			UInt64 stop;
			UInt64 result;

            Console.WriteLine("GPI11BXX-2 Aufgabe 1");
            Console.WriteLine("Berechnet die Summe aller natuerlichen Zahlen vom Startwert bist Stopwert");
			start = ask_user_for_UInt64("insert start value UInt64: ");

			do
			{
				stop = ask_user_for_UInt64("insert stop value UInt64 (stop>start): ");
			} while (stop < start);
				
			result = lesson_a(start, stop);
			Console.WriteLine("Lesson A thinks sum is: {0}", result);

			result = lesson_b(start, stop);
			Console.WriteLine("Lesson B thinks sum is: {0}", result);

			result = lesson_c(start, stop);
			Console.WriteLine("Lesson C thinks sum is: {0}", result);

			result = lesson_d(start, stop);
			Console.WriteLine("Lesson D thinks sum is: {0}", result);
		}
	}
}
