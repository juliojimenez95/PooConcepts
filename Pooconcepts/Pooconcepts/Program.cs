using Pooconcepts;

Console.WriteLine("Concepts Poo");
Console.WriteLine("============");
try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 11, 5));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}
