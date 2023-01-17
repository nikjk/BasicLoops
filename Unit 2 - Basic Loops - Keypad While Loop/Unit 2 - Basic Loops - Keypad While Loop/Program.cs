int keycode = 13579;

int userinput = 0;

Console.WriteLine("Please enter the code to unlock the door.");

userinput = int.Parse(Console.ReadLine());

while(keycode != userinput)
{
    Console.WriteLine("Code incorrect. Please try again.");

    userinput = int.Parse(Console.ReadLine());
}

Console.WriteLine("Door has been unlocked. Welcome home!");