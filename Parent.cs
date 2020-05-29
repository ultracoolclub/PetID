using System;

namespace PetID{

    class Parent
    {
       public string name;
       public string address;
       public string email;
       public string phone;

       public Parent()
       {
            Console.Write("Tell us your name. ");
            name = Console.ReadLine();

            Console.Write("Where do you and your pets reside? ");
            address = Console.ReadLine();

            Console.Write("What's your email address? ");
            email = Console.ReadLine();

            Console.Write("The last thing we need is your phone number.");
            phone = Console.ReadLine();
            
            Console.WriteLine($"Thanks {name}! Your profile is complete. Take a look. \n Name: {name} \n Address: {address} \n Email: {email} \n Phone: {phone}");
       }

      
    }

}