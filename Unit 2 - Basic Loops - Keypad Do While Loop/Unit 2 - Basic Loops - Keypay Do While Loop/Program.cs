int keycode = 13579;

int userinput = 0;
int attempt = 1;

Console.WriteLine("Please enter the code to unlock the door.");

userinput = int.Parse(Console.ReadLine());
do
{
    if (attempt < 5)
    {
        Console.WriteLine("Attempt " + attempt + "." + " Code incorrect. Please try again.");
        attempt++;

        userinput = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Attempt " + attempt + "." + " You have exceeded the number of allowed attempts. Please try again later.");
        break;
    }
} while (keycode != userinput);

if (keycode == userinput && attempt < 5)
{
    Console.WriteLine("Door has been unlocked. Welcome home!");
}
