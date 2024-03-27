using System;
using System.Runtime.InteropServices;


namespace consoleProject
{
	static class Pendu
	{
			public static void penduGame()
			{
				
				Console.WriteLine("             Le Pendu !      ");
				//L'utilisateur chosit en combien de tours il veut jouer
				
				Console.WriteLine("-------------------------------------");
				int round = 0;
				string[] word = ["apple", "banana", "carrot", "date", "egg", "fig", "grape", "honey", "kiwi", "lemon", "mango", "nut", "orange", "pear", "quince", "raspberry", "strawberry", "tangerine", "udon", "vanilla", "watermelon", "xigua", "yam", "zucchini"];
				Random rdn = new Random();
				
				string wordToFind = word[rdn.Next(0,word.Length)]; 
				
				char[] arr = new char[wordToFind.Length];
				Utils.printCase1();
				Console.Write("Le mot a trouver est : ");
				
				for (int i=0; i <= arr.Length-1;i++)
				{
						arr[i]= '_';
						Console.Write(arr[i]);
				}		
  				
				
				while(round<=8)
				{
					Console.WriteLine("***");
					Console.Write("Il vous reste {0} tours !",round);
					//demander a l'utilisateur de choisir un nombre et le convertit en int
					Console.Write("Veuillez choisir une lettre : ");
					char c = Console.ReadKey().KeyChar;
					
					if(c == 'q') //si le joueur veut quitter
					{
						Console.Write("Voulez-vous vraiment quitter? o/n");
						if(Console.ReadKey().Equals('o') ) return;
					}
					
					if(!Utils.letterCheck(wordToFind ,c)) //check si  la lettre est dans le mot ou pas
					{
						round++; //ajoute 1 a la var round pour dire le le tour est perdu
						switch (round)
						{
							case 8 :
								Utils.printCase8();
								break;
							case 7 :
								Utils.printCase7();
								break;
							case 6 :
								Utils.printCase6();
								break;
							case 5 :
								Utils.printCase5();
								break;
							case 4 :
								Utils.printCase4();
								break;
							case 3 :
								Utils.printCase3();
								break;
							case 2 :
								Utils.printCase2();
								break;
							case 1 :
								Utils.printCase1();
								break;							
						}
					}
					else //la lettre est dans le mot
					{
						for(int a = 0 ; a < word.Length ; a++)
						{
							if(wordToFind[a].Equals(c))
							{
								 arr[a] = c ;
								
							}
						}
					}
					Utils.printWord(arr);
					
					
					
					
					
					
					
					round--;	
					
					
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