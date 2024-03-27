using System;


namespace consoleProject
{
	static class Exercices2
	{
		//Exo 1
		public static string firstSecondChar (string str){
			if(str.Length < 2) 
				return str;
			string result= ""; 
			result+=str[0];
			result+=str[str.Length-1];
			return result;
		}
		//Exo 2
		public static void printArr(int[] tab){
			Console.WriteLine("[");
			for(int i = 0; i<tab.Length ;i++)
			{
				if(i != tab.Length -1 ) Console.Write(tab[i] + ", ");
				else Console.Write(tab[i]);
			}
			Console.WriteLine("]");
			
		}
	   
		public static int[] randomizerArr(int[] tab){
			int[] result = new int[tab.Length] ;
			bool[] check = new bool[tab.Length];
			Random rdm = new Random();
			int a;
			for(int i = 0 ; i < tab.Length; i++)
				check[i]=true;

			for(int i = 0 ; i < tab.Length;i++)
			{
				a = rdm.Next(0,tab.Length);
				while(!check[a])
					a = rdm.Next(0,tab.Length) ;
				check[a] = false;
				result[i] = tab[a];
			}
			printArr(result);
			return result;
		}   
		
		
		
		
		
		
		//Exo 3
		public static void determineNum (int i){
			if (i < 0) Console.WriteLine("Le nombre est négatif");
			else if (i > 0)  Console.WriteLine("Le nombre est positif");
			else  Console.WriteLine("Le nombre est nul");
		}

		//Exo 4 
		public static int countTab (int[] tab, int ct){
			int cpt = 0 ;
			for(int i = 0; i < tab.Length-1; i++){
				if(tab[i]==ct)
					cpt++;
			}
			return cpt;
		}

		

	}
}