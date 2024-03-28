
using  System;
using System.Linq;

namespace consoleProject
{
class Program
{
	static void Main(string[] args)
	{  
		Console.WriteLine("Combien de notes souhaitez-vous entrer ?");
		int.TryParse(Console.ReadLine(),out int nombreDeNotes);
		double[] notes = new double[nombreDeNotes];

		for (int i = 0; i < nombreDeNotes; i++)
		{
			Console.WriteLine($"Entrez la note {i + 1}:");
			notes[i] = Convert.ToDouble(Console.ReadLine());
		}

		double moyenne = CalculerMoyenne(notes);
		Console.WriteLine($"La moyenne des notes est : {moyenne}");

		Console.WriteLine("Les notes supérieures à la moyenne sont : ");
		AfficherNotesSupérieures(notes, moyenne);

		
	  
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

    static void AfficherNotesSupérieures(double[] notes, double moyenne)
    {
        foreach (double note in notes)
        {
            if (note > moyenne)
            {
                Console.WriteLine(note);
            }
        }
    }
}
}
