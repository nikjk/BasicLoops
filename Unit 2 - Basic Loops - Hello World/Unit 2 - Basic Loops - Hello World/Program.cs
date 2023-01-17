using System;

string startover = null;

do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");

    startover = Console.ReadLine();


} while (startover == "y" || startover == "Y");

Console.WriteLine("Goodbye!!!");
