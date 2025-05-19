using System;


Console.WriteLine("Modificació des de VS Code");

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

Console.WriteLine("Introdueix un número per calcular els seus múltiples menors que 100:");
if (int.TryParse(Console.ReadLine(), out int numero))
{
    Console.WriteLine("Multiples de " + numero + " menors que 100: " + string.Join(", ", Metodes.comptadorMultiples(numero)));
}
else
{
    Console.WriteLine("Si us plau, introdueix un número vàlid.");
    Console.WriteLine("Modificació des de GitHub");

}





