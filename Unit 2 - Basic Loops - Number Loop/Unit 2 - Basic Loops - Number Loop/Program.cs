bool isValid = false;

do
{


    string usernum = null;
    Console.Write("Enter a number: ");
    usernum = Console.ReadLine();

    int num = int.Parse(usernum);

    for (int i = num; i >= 0; i--)
    {
        Console.Write(" " + i);
    }
    Console.WriteLine(" ");
    for (int i = 0; i <= num; i++)
    {
        Console.Write(" " + i);
    }
    Console.WriteLine(" ");
    Console.Write("Would you like to continue (y/n)?");
    string userinput = Console.ReadLine();

    if (userinput == "y" || userinput == "Y")
    {
        isValid = true;
    }
    else
    {
        isValid= false;
    }
} while (isValid);

Console.WriteLine("Goodbye!");