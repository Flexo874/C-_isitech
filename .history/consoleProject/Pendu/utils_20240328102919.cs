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
		
		 public static bool ContainsLetter(char[] guessedWord, char letter)
		{
			int i = -1;
			while (++i < guessedWord.Length)
				if (guessedWord[i] == letter) return true;
			return false;
		}
		
		 public static string GetWord(string path = "Pendu/word_bank.txt")
		{
			if (!File.Exists(path))
				throw new ArgumentException("Le fichier est introuvable : " + path);
			
			try
			{
				var index = new Random().Next(File.ReadLines(path).Count());
				return File.ReadLines(path).Skip(index).Take(1).First();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		
		
		
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
		
		
		public static void Quit(char c)
		{
			if(c == 'q') //si le joueur veut quitter				
					{
						Console.Write("Voulez-vous vraiment quitter? o/n : ");//On verifie si c'est q pour savoir si l'on quitte le jeu
						if(Console.ReadKey().KeyChar == 'o' ) System.Environment.Exit(1) ;
						
					}
		}
		
		
		public static void gameStatement(int round, string wordToFind)
		{
			switch (round)				//met le bon schema de pendu en fonction des erreurs
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
				Console.WriteLine("||      /|\\");
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
				Console.WriteLine("||      /|");
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
				Console.WriteLine("||       |");
				Console.WriteLine("||       |");
				Console.WriteLine("||      ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("||           ");
				Console.WriteLine("==========");
			}
			public static void printCase2()
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
			
			public static void printCase1()
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
			
			public static void printCase0()
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