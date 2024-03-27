using System;


namespace consoleProject
{
	static class Exercices1
	{
		//Exo 1
		public static void tempConverter()
		{
			Console.Write("Ecrivez la temperature: ");
			while(true) {
			try{
				double temp = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("La temperature est : " + ((temp*1.8d)+32) + "°F");
			break;
			}
			catch(FormatException)
			{
				Console.Error.WriteLine("Veuillez saisir une temperature valide.");
				Console.Write("Ecrivez la temperature: ");
			}
		   }

		   
		}
			//Exo 2
			public static void moyenneCalculator(){
				
				Console.Write("Saisissez la premiere note: ");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Saisissez la deuxieme note: ");
				double b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Saisissez la troisieme note: ");
				double c =Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("La moyenne est de : "+((a+b+c)/3));
			}
			
		
			
			//Exo 3
			public static void  isPair() 
			{
				Console.Write("Veuillez saisir un nombre : ");
				int n = Convert.ToInt32(Console.ReadLine());
				if(n == null) return;
				string str = n%2==0
						?"Le nombre est pair"
						:"Le nombre est impair";
				Console.WriteLine(str);        
			}
			//Exo 4
			public static void multiples(){
				int num = Convert.ToInt32(Console.ReadLine());
				for (int i =1; i<=10;i++ )
				{
				int mult = num * i;
				Console.Write("{0} ",mult);
				}
			}
		//Exo5
			public static void primaryNumSumm()
			{
				Console.Write("Veuillez saisir un nombre");
				int num = Convert.ToInt32(Console.ReadLine());
				int sum=1;
				for(int i = 0; i <= num ; i++)
				{
					sum+=i;
				}
				Console.Write(sum);
			}
		  
	}    
}