using System;


namespace consoleProject
{
    static class Exercices1
    {
        //Exo 1
        public static void tempConverter(){
           int temp = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine((temp*1.8f)+32);
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