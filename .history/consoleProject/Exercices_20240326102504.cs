using System;


namespace consoleProject
{
    static class Exercices
    {
        //Exo 1
        public static bool isInArray (int[] tab, int n)
        {
            for(int i =0; i < tab.Length-1; i++){
                if (tab[i] == n)
                    return true;
            }
            return false;
        }

       

        //Exo 2

       public static string ReverseString(string input)
       {
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        return reversed;
        }

        //Exo 3

        public static int voyelleCounter(string str){
            int counter = 0;
           foreach(char c in str){
            if (c=='a' || c=='e' || c=='i' || c=='o'|| c=='u' || c=='y' || c=='A' || c=='E' || c=='I' || c=='O'|| c=='U' || c=='Y')
                counter++;
           }
           return counter;
        }
        //Exo 4

        public static int sumIntArray (int[] tab){
            int sum = 0;
            foreach(int i in tab)
                sum+=i;
            return sum;    
        }

        //Exo5

        public static int maxIntArray (int[] tab){
            int max = int.MinValue;
            for(int i = 0; i < tab.Length ; i++)
            {
                if(tab[i] > max )
                    max = tab[i];
            }
            return max;
        }

    }
}