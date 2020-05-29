using System;

namespace PetID{

    class Pet
    {
       public string name;
       public string kind;
       public string chip;
       public string breed;
       public string characteristics;
       public string vaccines;

       public Pet()
       {
            Console.Write("What's your pet's name? ");
            name = Console.ReadLine();

            Console.Write("Is your pet a dog, a cat, or something else? ");
            kind = Console.ReadLine();

            Console.Write("Enter your pet's microchip number. ");
            chip = Console.ReadLine();

            Console.Write("What is your pet's breed? ");
            breed = Console.ReadLine();

            Console.Write("Tell us about your pet's personality and any distinguishing markings. ");
            characteristics = Console.ReadLine();

            Console.Write("Is your pet up-to-date on vaccinations? Yes or No? ");
            vaccines = Console.ReadLine();
            
            Console.WriteLine($"Here's {name}'s brand new profile. \n Name: {name} \n Kind: {kind} \n Chip: {chip} \n Breed: {breed} \n Characteristics: {characteristics} \n Vaccines: {vaccines}");
       }

      
    }

}