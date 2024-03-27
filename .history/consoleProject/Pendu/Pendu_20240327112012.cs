using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;


namespace consoleProject
{
	static class Pendu
	{
			public static void penduGame()
			{
				
				Console.WriteLine("             Le Pendu !      ");
				//L'utilisateur chosit en combien de tours il veut jouer
				
				Console.WriteLine("-------------------------------------");
				int round = 8;
				string[] word = ["apple", "banana", "carrot", "date", "egg", "fig", "grape", "honey", "kiwi", "lemon", "mango", "nut", "orange", "pear", "quince", "raspberry", "strawberry", "tangerine", "udon", "vanilla", "watermelon", "xigua", "yam", "zucchini"];
				Random rdn = new Random();
				var wordToFind = word[rdn.Next(0,word.Length)]; 
				
				
				int i = -1; //On initialise l'index à -1
				char[] guessedWord = wordToFind.ToCharArray(); //On transforme le mot a trouver en array
				while (++i < guessedWord.Length) guessedWord[i] = '_'; //On remplace les lettres par "_"
				
				
				
				
				
				Utils.printCase1();
				Console.WriteLine("Le mot a trouver est : {0} ",new string (guessedWord));
				
				
  				
				
				while(round >= 0)
				{
					Console.WriteLine("Il vous reste {0}/8 chances !",round);
					
					char c = Utils.GetInput();
					Console.WriteLine("Laaaaaaaaaaaa lettre est : "+c);
					
					if(c == 'q') //si le joueur veut quitter
					{
						Console.Write("Voulez-vous vraiment quitter? o/n : ");
						if(Console.ReadKey().KeyChar == 'o' ) System.Environment.Exit(1) ;
					}
					
					if(Utils.ContainsLetter(guessedWord,c)) //check si  la lettre est dans le mot ou pas
					{
						round--; //ajoute 1 a la var round pour dire le le tour est perdu
						
						switch (round)
						{
							case 1 :
								Utils.printCase8();
								Console.WriteLine("C'est perdu ! Dommage. Le mot était " + wordToFind); 
								return;
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
					else
					{
						Console.WriteLine("Le mot est dedans");
					}
					
					
				
					
					
				}
			
			
			
			
			
			}
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
		
	}
}




















/*

	============
	|| //    |
	||//     |
	||/      |
	||       O
	||      /|\
	||       |
	||      / \
	||
	||
	||
	==========

*/