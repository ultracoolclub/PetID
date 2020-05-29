using System;

namespace PetID
{
    class Professional
    {
        public string name;
        public string organization;
        public string workAddress;
        public string email;
        public string phone;

    public Professional()
    {
         Console.Write("What's your name? ");
         name = Console.ReadLine();

         Console.Write("What organization are you affiliated with? ");
         organization = Console.ReadLine();

         Console.Write("What's the organization's street address? ");
         workAddress = Console.ReadLine();

         Console.Write("What is your email? ");
         email = Console.ReadLine();

         Console.Write("What's your phone number? ");
         phone = Console.ReadLine();

         Console.WriteLine($"Thanks {name}! Your profile is complete. Take a look. \n Name: {name} \n Organization: {organization} \n Address: {workAddress} \n Email: {email} \n Phone: {phone}");

    }

    }
}