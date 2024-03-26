using System;


namespace consoleProject
{
	static class Game
	{
		public static void justPrice()
		{
			//créée un nombre au hasard entre 0 et 10000
			Random rnd = new Random();
			int toFind = rnd.Next(0,10001);
			//Mise en place de la presentation
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("          Voici le juste prix        ");
			//L'utilisateur chosit en combien de tours il veut jouer
			Console.Write("Veuillez choisir un nombre de tours limite : ");
			int lap = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("-------------------------------------");
			
			while(lap >= 0)
			{
				//donne le nombre de tours restant et soustrait un tour a chaque bloucle
				Console.Write("Il vous reste {0} tours !",lap);
				lap--;
				//demander a l'utilisateur de choisir un nombre et le convertit en int
				Console.Write("Veuillez choisir un nombre entre 0 et 10000 : ");
				int i = Convert.ToInt32(Console.ReadLine());
				
				//nouvelle variable qui prends en charge les cas donnés par la fonction checkNumber
				int isFound = checkNumber(i , toFind);
				
				//Switch qui compare les cas 0, 1, 2 et ecrit en fonction du resultat si c'est plus/moins/gagné
				switch(isFound)
				{
					case  0 :
						Console.WriteLine("C'est plus !");
						break;
					case  2 : 
						Console.WriteLine("C'est moins !");
						break;
					default :
						Console.WriteLine("C'est gagné");
						return;
				}
				Console.WriteLine("-------------------------------------");	
			}
			Console.Write("Le nombre a deviner etait {0}", toFind);
		}
		
		//Fontion qui renvoie soit 0, 1 ou 2 en fonction si le chiffre donné par l'utilisateur est inferieur, superieur ou egal a celui de la machine
		public static int checkNumber (int i, int pc)
		{
			return i < pc ? 0 
					: i==pc ? 1 
					: 2; 
		}
			
			
			
			
			
		
		  
	}    
}