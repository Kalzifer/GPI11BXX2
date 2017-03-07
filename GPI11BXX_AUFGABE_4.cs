/*
 * Created by VIM
 * User: Frank Schmidt
 * Date: 03.03.2017
 * Time: 23:31
 * 
 */
using System;
using System.Threading;
	
namespace GPI11BXX_AUFGABE_4
{
	class Program
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("PI11BXX2 AUFGABE 4");
            Console.WriteLine("Collatz");
			
			for(int i = 1; i < 100; i++)
			{
				int zahl = i;
				Console.Write("Start Wert={0}: ", i);
				do
				{
					if(zahl % 2 == 0)
					{
						zahl = zahl/2;
					}
					else
					{
						zahl = zahl * 3 + 1;
					}
					Console.Write("{0} ", zahl);
				} while(zahl != 1);
				Console.WriteLine("Done");
				Console.WriteLine("========================================");
			}
		}
	}
}
