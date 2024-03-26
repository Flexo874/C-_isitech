using System;


namespace consoleProject
{
	static class Game
	{
		public static void justPrice()
		{
			Random rnd = new Random();
			int toFind = rnd.Next(0,10001);
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("          Voici le juste prix        ");
			Console.Write("Veuillez choisir un nombre de tours limite : ");
			int lap = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("-------------------------------------");
			
			while(lap >= 0)
			{
				lap--;
				Console.Write("Il vous reste {0} tours !",lap);
				Console.Write("Veuillez choisir un nombre entre 0 et 10000:");
				int i = Convert.ToInt32(Console.ReadLine());
				
				int isFound = checkNumber(i , toFind);
				
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
						lap = 0 ;
						break;
				}
			}
		}
		
		public static int checkNumber (int i, int pc)
		{
			return i < pc ? 0 
					: i==pc ? 1 
					: 2; 
		}
			
			
			
			
			
		
		  
	}    
}