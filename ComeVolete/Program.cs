
Console.WriteLine("Console Start App");
Console.WriteLine("Inserire il Nome");
var name = Console.ReadLine();

Console.WriteLine("Inserire una Lettera");
var key = Console.ReadKey();
Console.WriteLine();

if(key.Key == ConsoleKey.Y)
{

}

if (key.KeyChar == 'Y')
{
    Console.WriteLine("la y è maiuscola");
}

if (key.KeyChar == 'y')
{
    Console.WriteLine("la y è minuscola");
}

Console.WriteLine("inserire un numero");
var numInput = Console.ReadLine();

if (int.TryParse(numInput, out int num))
{
    if (num > 10)
    {
        Console.WriteLine("il numero è maggiore di 10");
    }
}
else
{
    Console.WriteLine("il dato inserito non è un numero");
}