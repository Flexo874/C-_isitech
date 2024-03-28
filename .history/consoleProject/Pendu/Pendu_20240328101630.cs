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
				int count =0;
				Console.WriteLine("-------------------------------------");
				Console.WriteLine("             Le Pendu !      ");
				//L'utilisateur chosit en combien de tours il veut jouer
				
				Console.WriteLine("-------------------------------------");
				int round = 8;
				




				/*
				 *La liste de mots peut etre remplacée par la fonction Utils.GetWord()
				 *qui prends un mot au hasard dans word_bank.txt	
				 *Le problem est que je sais pas quel path mettre dans la fct
				 */
				
				/**************************************************/
				string[] word = ["apple", "banana", "carrot", "date", "egg", "fig", "grape", "honey", "kiwi", "lemon", "mango", "nut", "orange", "pear", "quince", "raspberry", "strawberry", "tangerine", "udon", "vanilla", "watermelon", "xigua", "yam", "zucchini"];
				Random rdn = new Random();
				string wordToFind = word[rdn.Next(0,word.Length)]; 
				/**************************************************/
				
				int i = -1; 											 //On initialise l'index à -1
				char[] guessedWord = wordToFind.ToCharArray(); 			//On transforme le mot a trouver en array
				while (++i < guessedWord.Length) guessedWord[i] = '_'; //On remplace les lettres par "_"
				Utils.printCase1();
				
				
				while(round >= 0)
				{
					count++;																	//On augment le tours passés
					Console.WriteLine("Le mot a trouver est : {0} ",new string (guessedWord));
					Console.WriteLine("Il vous reste {0}/7 chances !",round-1);
					
					char c = Utils.GetInput();													//On obtient la lettre tapée par l'utilisateur
					Utils.Quit(c);
					Console.Clear();
					Console.WriteLine("-------------------------------------");
					if(Utils.ContainsLetter(wordToFind.ToCharArray(),c)) //check si  la lettre est dans le mot ou pas
					{
						for(int a = 0 ; a < wordToFind.Length ; a++)	//remplace dans guessedword les '_' par la lettre
						{
							if(wordToFind[a] == c)
								guessedWord[a]=c;
						}
						Console.WriteLine("Vous avez trouvé une lettre ! Bravo !");	
					}
					else
					{
						round--; //retire 1 a la variable round pour dire que le tour est perdu
						Console.WriteLine("La lettre n'est pas trouvé");
					}
					Utils.gameStatement(round,wordToFind); 
					if(new string(guessedWord) == wordToFind)	// verifie si toutes les lettres ont été trouvées
					{
						Console.WriteLine("Felicitations ! Vous avez gagné !\n Vous avez fait {0} tentatives. Le mot etait bien {1}",count,wordToFind);
						Utils.reloadask();
						return;
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