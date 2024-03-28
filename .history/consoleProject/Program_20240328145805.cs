
using  System;
using System.Linq;

namespace consoleProject
{
class Program
{
	static void Main(string[] args)
	{  
		Console.WriteLine("Combien de notes souhaitez-vous entrer ?");
		
		
	
		int nombreDeNotes =0;
		while(true)
		{
			try
			{
				 nombreDeNotes = Convert.ToInt32(Console.ReadLine());
				 if(nombreDeNotes < 0) 
				 	throw new FormatException("Veuillez saisir un nombre positif");
				break;
			}
			catch(FormatException)
			{
				Console.Error.WriteLine("Argument invalide! \n Combien de notes souhaitez-vous entrer ?"  );
				continue;
			}
		}
		
		
		double[] notes = new double[nombreDeNotes];
		string[] nom = new string [nombreDeNotes];
		for (int i = 0; i < nombreDeNotes; i++)
		{
			Console.WriteLine($"Entrez la note {i + 1}:");
			notes[i] = getInput();
			Console.WriteLine("Entrez  le nom de l'élève: ");
			nom[i]=Console.ReadLine()!;
		}

		double moyenne = CalculerMoyenne(notes);
		Console.WriteLine($"La moyenne des notes est : {moyenne}");

		Console.WriteLine("Les notes supérieures à la moyenne sont : ");
		AfficherNotesSupérieures(notes, moyenne,nom);
	}
	
		 static double getInput()
		{
			while(true)
		{
			try
			{
				double nombreDeNotes = Convert.ToInt32(Console.ReadLine());
				return nombreDeNotes;
				
			}
			catch(FormatException)
			{
				Console.Error.WriteLine("Argument invalide! Veuillez saisir un nombre."  );
				continue;
			}
		}
		}
	static double CalculerMoyenne(double[] notes)
	{
		double somme = 0;
		foreach (double note in notes)
		{
			somme += note;
		}
		return somme / notes.Length;
	}

	static int AfficherNotesSupérieures(double[] notes, double moyenne,string[] nom)
	{
		int count = 0;
		for(int i = 0;i <  notes.Length; i++)
		{
			if (notes[i] > moyenne)
			{
				Console.WriteLine("{0} : {1}",nom[i],notes[i]);
				count++;
			}
		}
		return count;
	}
}
}
