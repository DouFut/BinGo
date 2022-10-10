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
// boucle sur les essais
while (Essai != Nombre)
{
    // test de l'essai par rapport à la valeur à chercher
    if (Essai > Nombre)
    {
        Console.WriteLine(" --> too Big !");
    }
    else
    {
        Console.WriteLine(" --> too Small !");
    }
    // saisie d'un nouvel essai
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
    // compteur d'essais
    Attempt++;
}
// valeur trouvée
Console.WriteLine("You find it in " + Attempt+ " attempt !");
Console.ReadLine();