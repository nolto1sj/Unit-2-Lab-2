bool loop = true;
do
{
    Console.WriteLine("Please enter a whole number");
    int input = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    for (int i = input; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    for (int i = 0; i <= input; i++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Would you like to continue? (y/n)");
    string response = Console.ReadLine();
    if (response == "y")
    {

    }
    else if (response == "n")
    {
        Console.WriteLine("Goodbye!");
        break;
    } else
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}
while (loop);
