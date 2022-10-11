int Nombre = 0;
int Essai = 0;
int Attempt;
Attempt = 1;
bool correct = false;


while (!correct)
{
    try
    {
        Console.WriteLine("Choose a Number");
        Nombre = int.Parse(Console.ReadLine());
        correct = true;
    }
    catch
    {
        Console.WriteLine("Error: Choose a Number");
    }
}
Console.Clear();
correct = false;
while (!correct)
{
    try
    {
        Console.Write("Try a Number = ");
        Essai = int.Parse(Console.ReadLine());
        correct = true;
    }
    catch
    {
        Console.WriteLine("Error: Choose a Number");
    }
}
while (Essai != Nombre)
{
    if (Essai > Nombre)
    {
        Console.WriteLine(" --> too Big !");
    }
    else
    {
        Console.WriteLine(" --> too Small !");
    }
    correct = false;
    while (!correct)
    {
        try
        {
            Console.Write("Choose a Number = ");
            Essai = int.Parse(Console.ReadLine());
            correct = true;
        }
        catch
        {
            Console.WriteLine("Error: Choose a Number");
        }
    }
    Attempt++;
}
Console.WriteLine("You find it in " + Attempt+ " attempt !");
Console.ReadLine();
