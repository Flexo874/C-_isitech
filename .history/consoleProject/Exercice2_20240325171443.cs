using System;


namespace consoleProject
{
    static class Exercices2
    {
        //Exo 1
        public static string firstSecondChar (string str){
            string result= ""; 
            result+=str[0];
            result+=str[str.Length-1];
            return result;
        }
        //Exo 2
        
        
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