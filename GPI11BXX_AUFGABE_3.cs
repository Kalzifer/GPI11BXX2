/*
 * Created by SharpDevelop.
 * User: Frank Schmidt
 * Date: 02.03.2017
 * Time: 11:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */



/*
Bitte das nächste mal keine PDF bei der man den Quellcode nicht kopieren kann
Hardcopy+OCR bei quelcode ist so mehhh

3. Im folgenden Programm ist ein kleines Menü programmiert:
using System;

public class EingabOl {
	public static void MainO {
	
	int zahl;
	
	while(true) { // Endlosschleife
		Console.HriteLine("Bitte wählen Sie (1, 2, 3"
		+ " oder 9 für Ende): ");
		zahl = Int32 .Parse (Console . ReadLine ()) ;
		
		if(zahl = 1) {
		ConsoleJlriteLineU'Die Zahl ist eins.");
		continue; // weiter zur Auswahl
		}
		if(zahl = 2) {
		ConsoleJlriteLineU'Die Zahl ist zwei.");
		continue; // weiter zur Auswahl
		
		}
		if(zahl = 3) {
		ConsoleJlriteLineU'Die Zahl ist drei.");
		
		continue; // weiter zur Auswahl
		}
		if (zahl = 9) {
		
		break; // Schleife verlassen
		}
		
		Console.HriteLine("Falsche Eingabe, "
		+ "bitte wiederholen. ") ;
	
	}
	Console .HriteLine ("Programm-Ende . ") ;
	
	}
}

Formulieren Sie jetzt das Programm um, sodass ein funldionsäquivalentes Programm
entsteht, das ohne cont inue in der Schleife auskommt. Anstelle der if—Anweisungen

sollen Sie eine switch-Anweisung verwendet, um das Programm zu vereinfachen.
*/


using System;
using System.Threading;
namespace GPI11BXX_AUFGABE_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int zahl;
			bool is_valid;
			bool stop = false;
			do
			{
				Console.Write("Bitte waehlen Sie (1, 2, 3 oder 9 fuer Ende): ");
				is_valid = Int32.TryParse(Console.ReadLine(), out zahl);
				if(is_valid)
				{
					switch(zahl)
					{
						case 1:
							stop = true;
							break;
						case 2:
							stop = true;
							break;
						case 3:
							stop = true;
							break;
						case 9:
							stop = true;
							break;
					}
				}
			} while(! stop);
			Console.WriteLine("Programm-Ende .");
		}
	}
}
