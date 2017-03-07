/*
 * Created by SharpDevelop.
 * User: win7pro64
 * Date: 04.03.2017
 * Time: 02:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ostern
{
	class Program
	{
		public static void Main(string[] args)
		{
			int year = 1901;
			string user_content;
			bool vaild_argument = false;
			
			if(args.Length > 0)
			{
				vaild_argument = int.TryParse(args[0],out year);
			}
			
			if(! vaild_argument) 
			{
				do
				{
					Console.Write("Geben sie das Jahr ein: ");
					user_content = Console.ReadLine();
				} while(! int.TryParse(user_content, out year));
			}

			int K = year / 100;
			int M = 15 + (3*K+3) / 4-(8*K+13) / 25;
			int S = 2 -(3*K+3)/4;
			int A = year % 19;
			int D = (19 * A + M) % 30;
			int R = D/29 +(D/28-D/29) * A /11;
			int OG = 21 + D - R;
			int SZ = 7 - ((year + year / 4 + S) % 7);
			int OE = 7 - ((OG - SZ) % 7); 
			int OS = OG + OE;
			
			DateTime ostern = new DateTime(year,3,1).AddDays(OS-1);
			Console.WriteLine(ostern.ToString("dd.MM.yyyy"));
		}
	}
}
