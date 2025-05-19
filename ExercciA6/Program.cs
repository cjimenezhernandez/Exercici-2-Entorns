using System;



Console.WriteLine("Introdueix un valor enter:");
if (int.TryParse(Console.ReadLine(), out int valor))
{
    Console.WriteLine("Multiples de 7 menors que " + valor + ": " + Metodes.comptadorMultiples(valor));
}
else
{
    Console.WriteLine("Si us plau, introdueix un valor enter vàlid.");
}

Console.WriteLine("Multiples de 7 menors que 200:");
List<int> multiples = Metodes.comptadorMultiples(100);
Console.WriteLine(string.Join(", ", multiples));





