bool doorLocked = true;
for (int i = 4; i > -1; i--)
{
    do
    {
        Console.WriteLine("Please enter 5 digit keycode");
        int code = int.Parse(Console.ReadLine());
        if (code == 13579)
        {
            Console.WriteLine("Welcome!");
            i = -1;
        }
        else if (i == 0)
        {
            Console.WriteLine("Too many incorrect attempts. Locking Out.");
            i = -1;
        }
        else
        {
            Console.WriteLine("EH wrong, try again. " + i + " attempts remaining.");
            break;
        }
    } while (i >= 0);
}