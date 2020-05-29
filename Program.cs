using System;

namespace PetID
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting();
            greeting.HelloUser();
            
            
            while (Greeting.selection != "parent" || Greeting.selection != "professional")
            {
            if (Greeting.selection == "parent")
            {
                Parent parentInfo = new Parent();
                Pet petInfo = new Pet();
                break;
            }
            else if (Greeting.selection == "professional")
            {
                Professional proInfo = new Professional();
                break;
            }
            else
            {
                Console.WriteLine("Selection must be either 'parent' or 'professional'.");
                greeting.HelloUser();
            }
            }
        }
    }
}
