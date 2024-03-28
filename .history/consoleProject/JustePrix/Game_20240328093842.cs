using System;


namespace consoleProject
{
	static class Game
	{
		public static void justPrice()
		{
			Console.Clear();
			//créée un nombre au hasard entre 0 et 10000
			Random rnd = new Random();
			int toFind = rnd.Next(0,10001);
			
			//Mise en place de la presentation
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("          Voici le juste prix        ");
			
			//L'utilisateur chosit en combien de tours il veut jouer
			int lap = GetInput();
			Console.WriteLine("--------------------------------------------------");
			
			while(lap > 0)
			{
					//donne le nombre de tours restant et soustrait un tour a chaque bloucle
					Console.Write("Il vous reste {0} tours ! ",lap);
					
					//demander a l'utilisateur de choisir un nombre et le convertit en int
					Console.Write("Veuillez choisir un nombre entre 0 et 10000 : ");
					string str = Console.ReadLine()!;
					if(str == "q")return; // si lutilisateur saisi q alors quitte le jeu
					
					if  (int.TryParse(str,out int isFound) && isFound < 10000 && isFound > 0) //on parse la str en int et on verifie que le chiffre est entre 0 et 10000
					{
						lap--;
						//Switch qui compare les cas 0, 1, 2 et ecrit en fonction du resultat si c'est plus/moins/gagné
						switch(checkNumber(isFound , toFind))
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
						Console.WriteLine("------------------------------------------------------------");	
					}
					else 
						Console.Error.WriteLine("Veuillez saisir un nombre valide !");
			}
			Console.WriteLine("Le nombre a deviner etait {0}", toFind);
			reloadask();
		}
		
		//Fontion qui renvoie soit 0, 1 ou 2 en fonction si le chiffre donné par l'utilisateur est inferieur, superieur ou egal a celui de la machine
		public static int checkNumber (int i, int pc)
		{
			return i < pc ? 0 
					: i==pc ? 1 
					: 2; 
		}
		
		
			public static void reloadask() //Fonction pour  revenir au début de la partie sans fermer
		{
			Console.Write("Voulez-vous rejouer ? O/n: ");
			string ans = Console.ReadLine()!;
			if (ans.ToLower()=="o") justPrice();
			else Environment.Exit(0);
		}
		
		public static int GetInput()
		{
			while(true)
			{
				Console.Write("Veuillez choisir un nombre de tours limite : ");
				
				if (!int.TryParse(Console.ReadLine(),out int lap) || lap < 0)
					{
						Console.WriteLine("Veuillez saisir un nombre valide !");
						Console.ReadKey();
						continue;
					}
				else return lap;
			}
		}
		
		
		
			
			
			
			
			
		
		  
	}    
}