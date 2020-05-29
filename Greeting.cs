using System;

namespace PetID 
{
    class Greeting 
    {

        public static string selection = null;
        public string HelloUser()
        {
            Console.WriteLine("Welcome to PetID!");
            Console.Write("Are you a pet parent or a pet professional? ");
            selection = Console.ReadLine();
            Console.WriteLine($"You selected {selection}! Let's create your profile.");
            return selection;
        }
    }
}