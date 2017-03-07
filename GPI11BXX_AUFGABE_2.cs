/*
 * Created by VIM
 * User: Frank Schmidt
 * Date: 02.03.2017
 * Time: 10:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 /*
 2. Schreiben Sie ein Programm, das eine Zeichenkette von der Tastatur einliest, die aus einzelnen Ziffern besteht, d. h. eine natürliche Zahl darstellen soll. 
 	a) Geben Sie diese Zeichenkette am Bildschirm aus. 
 	b) Wandeln Sie diese Zeichenkette in eine Zahl z vom Typ long um und geben Sie sie in einer neuen Zeile am Bildschirm aus. 
 	c) Berechnen Sie die Quersumme von z, d. h. die Summe der einzelnen Ziffern, und geben Sie diese ebenso am Bildschirm aus.
*/

using System;

namespace GPI11BXX_AUFGABE_2
{
	class Program
	{
		public static void Main(string[] args)
		{

			long z;  					// long ist keine natuerliche Zahl da negative werte erlaubt sind
			UInt64 natuerliche_zahl;
			string user_content;
            Console.WriteLine("GPI11BXX2 AUFGABE 2");
			
			// 2.a)
			do 
			{
				Console.Write("Geben sie eine natuerliche Zahl ein: ");
				user_content = Console.ReadLine();
				Console.WriteLine(user_content); 
				
			} while(! UInt64.TryParse(user_content, out natuerliche_zahl) );

			// 2.b)
			z = (long) natuerliche_zahl;					
			Console.WriteLine("Sie haben die Zahl {0} eingegeben", z);
			
			// 2.c)
			string z_as_text = z.ToString();
			long sum = 0;
			const int ascii_offset = 48;
			
			foreach(Char c in z_as_text) {
				sum += (c - ascii_offset);
			}
		    
			Console.WriteLine("die Quersumme von {0} betraegt {1}",z, sum);
		}
	}
}
