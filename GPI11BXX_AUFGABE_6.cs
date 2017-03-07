/*
 * Created by SharpDevelop.
 * User: Frank Schmidt
 * Date: 06.03.2017
 * Time: 19:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Heron
{
    	
	class Program
	{
		public static double calc(double value, double oldvalue)
		{
			double result =  0.5 * (oldvalue + value / oldvalue);
			return result;
		}
			
		public static void Main(string[] args)
		{

			for(int zahl = 1; zahl <= 10; zahl++)
			{
				Console.WriteLine("Wurzel von: {0}", zahl);
				double old_val = calc(zahl,1);
				for(int a = 0; a <= 5; a++)
				{
					old_val = calc(zahl,old_val);
					Console.WriteLine("Iteration: {0} {1}", a ,old_val);
				}
                Console.WriteLine("==================================");
			}
		}
	}
}
