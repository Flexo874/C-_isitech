# Projet C# 

Principes fondamentaux du language C#.


## Utilisation
**Compilation**

Pour compiler le code, il suffit de lancer la commande  
`dotnet build` dans le dossier du projet. 

Pour exécuter le code, utilisez la commande `dotnet run`.


**Variables :**
- `int` : Nombre entier
- `uint`  : Nombre entier non signé
- `float`  ou `double` : Nombre à virgule
- `bool` : Booléen, peut prendre la valeur true ou false
- `char` : Caractère unique
- `string` : Chaîne de caractères

**Operateurs :**
- `+`, `-`, `*`, `/` pour les nombres réels et entiers
- `%` pour le reste d'une division euclidienne 
- `==`, `<>`, `<=`, `>=`, `<`, `>` pour les comparaisons entre nombres réels et entiers
- `&&`, `||` pour les opérations logiques AND et OR
- `!` pour l'opération  NOT

*Example*

Example de fonction, en declarant des variables `int` et `bool` et utilisant des oerateurs logiques.

```csharp
int age = 14;
bool hasDrivingLicence = false;
bool isEmancipated = false ;

if (age >=18 && hasDrivingLicence || isEmancipated)
{
    Console.WriteLine("You can drive");
}      

else if (age >= 18 && !hasDrivingLicence)
{
       Console.WriteLine("You need to get your driving       licence");
}

else
{      
        Console.WriteLine("You can drive");
}        
```

**Boucles**
- `for`  : Une boucle qui répète une instruction un  nombre déterminé de fois. 
````csharp
int i = 20;
for (int a = 0; a < i; a++) {
   Console.WriteLine(i);
}
````
- `while` : Une boucle qui répète une instruction tant que la condition est vraie.
````csharp
int i = 0;
while (i<5){
    Console.WriteLine("Valeur de i :" + i);
    i++;
}
````
- `do while`: Une boucle qui répète une instruction au moins une fois, puis teste si la condition est encore vraie.

```csharp
int x = 0;
do{
    Console.WriteLine(x);
    x++;
} while (x < 10);
```
**Methodes**

Une méthode est une suite d'instructions qui peut être appelée à partir d'un autre programme. 

*Example*

````csharp
static void print (string message)  // La methode "print" prend en  parametre un string
{
    Console.Write (message);
}

static int add(int  num1, int num2) //Declaration de la methode
{
    return num1+num2;  //La methode renvoie le resultat de l'addition des deux nombres
}

//On peut appeler les methodes  comme suit:
print("Hello World");
int = result =  add (3,4);
print(result.ToString()); // On cast result (int) en string


````
**Tableaux**

Un tableau est une variable capable de stocker plusieurs valeurs sous forme d’éléments organisés.

*Exemple*

````csharp
int[] tab = new int[5];   //Déclaration d'un tableau d'entiers contenant 5 éléments

string[] daysOfTheWeek = ["Lundi","Mardi", "Mercredi","Jeudi","Vendredi"]; //Declaration  d'un tableau de strings

Console.WriteLine(daysOfTheWeek[0]); //Affiche Lundi
````








### Installation
#### NB


