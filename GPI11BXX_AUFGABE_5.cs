/*
 * Created by SharpDevelop.
 * User: Frank Schmidt
 * Date: 02.03
 * Time: 22:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Globalization;

namespace GPI11BXX_AUFGABE_5
{
	class Program
	{
	    
		public static void Main(string[] args)
		{
            CultureInfo CultureInfoGerman = new CultureInfo("de-DE");		
            
			Dictionary<string, List<DateTime>> sternzeichen = new Dictionary<string, List<DateTime>>()
		    {
				{"STEINBOCK" , new List<DateTime> { DateTime.Parse("23.12",CultureInfoGerman) ,DateTime.Parse("19.01",CultureInfoGerman)} },
				{"WASSERMAN" , new List<DateTime> { DateTime.Parse("20.01",CultureInfoGerman) ,DateTime.Parse("19.02",CultureInfoGerman)} },
				{"FISCHE"	 , new List<DateTime> { DateTime.Parse("20.02",CultureInfoGerman) ,DateTime.Parse("20.03",CultureInfoGerman)} },
				{"WIDDER"	 , new List<DateTime> { DateTime.Parse("21.03",CultureInfoGerman) ,DateTime.Parse("19.04",CultureInfoGerman)} },
				{"STIER"	 , new List<DateTime> { DateTime.Parse("20.04",CultureInfoGerman) ,DateTime.Parse("20.05",CultureInfoGerman)} },
				{"ZWILLING"	 , new List<DateTime> { DateTime.Parse("21.05",CultureInfoGerman) ,DateTime.Parse("20.06",CultureInfoGerman)} },
				{"KREBS"	 , new List<DateTime> { DateTime.Parse("21.06",CultureInfoGerman) ,DateTime.Parse("21.07",CultureInfoGerman)} },
				{"LOEWE"	 , new List<DateTime> { DateTime.Parse("22.07",CultureInfoGerman) ,DateTime.Parse("22.08",CultureInfoGerman)} },
				{"JUNGFRAU"	 , new List<DateTime> { DateTime.Parse("23.08",CultureInfoGerman) ,DateTime.Parse("22.09",CultureInfoGerman)} },
				{"WAAGE"	 , new List<DateTime> { DateTime.Parse("23.09",CultureInfoGerman) ,DateTime.Parse("22.10",CultureInfoGerman)} },
				{"SKORPION"	 , new List<DateTime> { DateTime.Parse("23.10",CultureInfoGerman) ,DateTime.Parse("21.11",CultureInfoGerman)} },
				{"SCHUETZE"  , new List<DateTime> { DateTime.Parse("22.11",CultureInfoGerman) ,DateTime.Parse("22.12",CultureInfoGerman)} },
		    };
					
			DateTime geburtstag;
			string user_content;
			Console.Write("Geburtstag (DD.MM): ");
			user_content = Console.ReadLine();
            geburtstag = DateTime.Parse(user_content,CultureInfoGerman);
			foreach(string key in sternzeichen.Keys) 
			{
				int compar_to_start = geburtstag.CompareTo(sternzeichen[key][0]);
				int compar_to_stop = geburtstag.CompareTo(sternzeichen[key][1]);
				
				if(key == "STEINBOCK")
				{
					compar_to_start = geburtstag.CompareTo(sternzeichen[key][0].AddYears(-1));
					if(geburtstag.Month == 12) 
					{
						DateTime dummy = geburtstag.AddYears(-1);
						compar_to_stop = dummy.CompareTo(sternzeichen[key][1]);
					}
				}
					
				if(compar_to_start >= 0 && compar_to_stop <= 0)
				{
					Console.WriteLine(key);
				}
			}
		}
	}
}
