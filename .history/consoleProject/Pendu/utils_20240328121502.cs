using System;
using System.Linq;
using System.IO;


namespace consoleProject
{
	public static class Utils
	{
		

		public static void printWord (char[] arr)
		{
				Console.Write(new string(arr));
		}
		
		
		
		//Fonction qui prends la lettre choisit par l'utilisateur et verifie qu'elle est valide
		  public static char GetInput()
		{
			while(true)
			{
				Console.Write("Veuillez saisir une lettre : ");
				char[] letter = Console.ReadLine()!.ToCharArray();
				if (!(letter.Length==1 && Char.IsLetter(letter[0])))
					{
						Console.WriteLine("Veuillez saisir une lettre valide !");
						Console.ReadKey();
						continue;
					}
				else return Char.ToLower(letter[0]);
			}
		}
		
		//Fonction qui verifie si la lettre est presente dans une string
		 public static bool ContainsLetter(char[] guessedWord, char letter)
		{
			int i = -1;
			while (++i < guessedWord.Length)
				if (guessedWord[i] == letter) return true;
			return false;
		}
		
		
		//Fonction qui renvoie un mot au hasard dans une liste de mots
		 public static string GetWord(int difficulty)
		{
			string easy = "Pendu/word_bank/easy.txt";
			string advanced = "Pendu/word_bank/advanced";
			string hard = "Pendu/word_bank/hard";
			
			string choice = difficulty == 1
							?easy
							:difficulty == 2
							?advanced
							:hard;
			
			if (!File.Exists(easy) || !File.Exists(advanced) ||!File.Exists(hard) )
				throw new ArgumentException("Le fichier est introuvable.");
			try
			{
				var index = new Random().Next(File.ReadLines(choice).Count());
				return File.ReadLines(choice).Skip(index).Take(1).First();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		
		
		//Fonction qui demande a l'utilisateur s'il veut rejouer a la fin de la partie
		public static void reloadask()
		{
			Console.Write("Voulez-vous rejouer ? O/n: ");
			string ans = Console.ReadLine()!;
			if (ans.ToLower()=="o") 
			{
				Console.Clear();
				Pendu.penduGame();
			}
			else 
			{
				Console.Clear();
				Environment.Exit(0);
			}
		}
		
		
		
		//Fonction qui permet de quitter le jeu a tout moment si le joueur appui sur "q"
		public static void Quit(char c)
		{
			if(c == 'q') 				
					{
						Console.Write("Voulez-vous vraiment quitter? o/n : ");//On verifie si c'est q pour savoir si l'on quitte le jeu
						if(Console.ReadKey().KeyChar == 'o' ) System.Environment.Exit(1) ;
						
					}
		}
		
		
		/*Fonction qui en fonction du nombre d'erreur print le bon schema du pendu
		 */
		public static void gameStatement(int round, string wordToFind)
		{
			switch (round)				
						{
							case 1 :
								Utils.printCase8();
								Console.WriteLine("C'est perdu ! Dommage. Le mot était {0} !",wordToFind); 
								Utils.reloadask();
								break;
							case 2 :
								Utils.printCase7();
								break;
							case 3 :
								Utils.printCase6();
								break;
							case 4 :
								Utils.printCase5();
								break;
							case 5 :
								Utils.printCase4();
								break;
							case 6 :
								Utils.printCase3();
								break;
							case 7 :
								Utils.printCase2();
								break;
							case 8 :
								Utils.printCase1();
								break;							
						}
		}
		
		
		
		
		
		public static int Menu()
		{
			Console.WriteLine("<-- MENU -->");
			
			Console.Write("1   - Facile\n");
			Console.Write("2   - Intermédiaire\n");
			Console.Write("3   - Difficile\n");
			Console.Write("4   - Quitter le jeu\n");
			Console.Write("Votre choix : ");
			if(!int.TryParse(Console.ReadLine()!,out int choice) || choice > 4 || choice < 0)
			{
				Console.Clear();
				Menu();
			}
			switch(choice)
			{
				case  1 :
					return 1;
				case  2 : 
					return 2;
				case  3 :
					return 3;
				case  4 :
					Quit('q');
					break;
			}
			return 0;
		}
		
		
		
		
		
		
		
		
		
		public static void printCase8()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||      /|\\");
				Console.WriteLine("||       |");
				Console.WriteLine("||      / \\");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("==========\n");
				
			}
			
			public static void printCase7()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||      /|\\");
				Console.WriteLine("||       |");
				Console.WriteLine("||      / ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("==========");
			}
			
		
			public static void printCase6()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||      /|\\");
				Console.WriteLine("||       |");
				Console.WriteLine("||      ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("==========");
			}
			public static void printCase5()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||      /|");
				Console.WriteLine("||       |");
				Console.WriteLine("||      ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("==========");
			}
			public static void printCase4()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||       |");
				Console.WriteLine("||       |");
				Console.WriteLine("||      ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("==========");
			}
			public static void printCase3()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||       O");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("==========");
			}
			
			public static void printCase2()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //    |");
				Console.WriteLine("||//     |");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("==========");
			}
			
			public static void printCase1()
			{
				Console.WriteLine("============");
				Console.WriteLine("|| //");
				Console.WriteLine("||//");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("||");
				Console.WriteLine("==========");
			}
	}
	
	
	
	
}