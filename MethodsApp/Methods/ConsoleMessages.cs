﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods;
public static class ConsoleMessages
{
    public static void SayHi()
    {
        Console.WriteLine("Hello User");
    }

    public static string GetUsersName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        return name;
    }

    public static (string firstName, string lastName) GetFullName()
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        return (firstName, lastName);
    }

    public static void SayGoodbye()
    {
        Console.WriteLine("Bye User");
    }

    public static void GreetByName(string firstName)
    {
        Console.WriteLine($"Hello {firstName}");
    }
}
