 bool greetings = true;
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue? (y/n)");
    string input = Console.ReadLine();
    if (input == "y")
    {

    }
    else if (input == "n")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}
while (greetings);