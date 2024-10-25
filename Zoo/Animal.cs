using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
// Declares a namespace called Zoo to organize classes and interfaces.
namespace Zoo 
{

    /* In the assignment discription, it states that the method should be use in every animal
     *to make sure the method  is implimented in every class I choose to have an Interface*/ 
    //Declares an interface named Isound.
    public interface Isound
    {
        // Interface method signature for making sound.
        void makeSound();
    }

    //Base class presenting a generic Animal.
    public abstract class Animal
    {
        // Property to store the name of the animal with default value.
        public string Name { get; set; } = "Unknown";
        // Property to store the species of the animal with default value.
        public string Species { get; set; } = "Unknown";
        // Property to store the Age of the animal with default value.
        public int Age { get; set; } = 0;
        //Property to indicate if the animal is endangered with default value.
        public bool IsEndangered { get; set; } = false;
        // Property to store the origin of the animal with a default value.
        public string Origin { get; set; } = "Unknown";

        // Contructor to initialize the Animal object with specified values.
        protected Animal(string name, string species, int age, bool isEndangered, string origin)
        {
            //Assigns the given name to the Name property.
            Name = name;
            //Assigns the given species to the Species property.
            Species = species;
            //Assigns the given age to the Age property.
            Age = age;
            //Assigns the given status to the IsEndangered property.
            IsEndangered = isEndangered;
            //Assigns the given origin to the Origin property.
            Origin = origin; 
        }
        // Virtual method to feed the animal, can be overriden by derived classes.
        public virtual void Feed()
        {
            //Default behavior for feeding.
            Console.WriteLine($"{Name} is a vegetarian! ");
        }

        //Method to display the animal´s information.
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} \nSpecies: {Species}\nAge: {Age} \nEndangered: {IsEndangered}\nBirthplace : {Origin}");
        }
    }
}
