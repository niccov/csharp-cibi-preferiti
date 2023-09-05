// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "Pizza", "Pasta", "Gelato", "Formaggio", "Lasagna", "Panelle", "Pollo"};

//stampare la lunghezza della classifica

Console.WriteLine("La classifica è lunga " + cibiPreferiti.Length + " elementi");

//stampare la lunghezza della classifica

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i] + " " + (i+1) + " posto");
}

//Il mio cibo top

Console.WriteLine("Il mio cibo preferito è " + cibiPreferiti[0]);

// Il mio cibo preferito ma non troppo

Console.WriteLine("Il mio cibo preferito ma non troppo è " + cibiPreferiti[cibiPreferiti.Length-1]);

//Stampare il cibo che si trova nella posizione mediana gestendo il caso di elementi pari.

if(cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine($"La classifica non ha una mediana");
} else
{
    Console.WriteLine($"La mediana di questa classifica è {cibiPreferiti[cibiPreferiti.Length / 2]}");
}