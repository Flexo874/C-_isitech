using System;


namespace consoleProject
{
    static class Exercices1
    {
        //Exo 1
        public static void tempConverter()
        {
            Console.Write("Ecrivez la temperature: ");
           double temp = Convert.ToDouble(Console.ReadLine());
            
           Console.WriteLine("La temperature est : " + ((temp*1.8d)+32) + "°F");
        }
        //Exo 2
        public static int moyenneCalculator(float a, float b, float c){
           return (int)(a+b+c)/3;
        }
        //Exo 3
        public static void  isPair(int n) 
        {
            string str = n%2==0
                    ?"Le nombre est pair"
                    :"Le nombre est impair";
            Console.WriteLine(str);        
        }
        //Exo 4
        public static void multiples(int num){
           for (int i =1; i<=10;i++ ){
            int mult = num * i;
            Console.Write("{0} ",mult);
           }
        }
        //Exo5
          
    }    
}