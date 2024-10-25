namespace Zoo
{
    // Declares the Elephant class, which inherits from Animal and implements the Isound interface
    public class Elephant: Animal,Isound 
    {
        // Property to store the trunk length of the elephant with a default value of 0
        public int TrunkLength { get; set; } = 0;
        // Constructor for Elephant class that initializes properties and calls the base class constructor
        public Elephant(string name = "Unknown", string species = "Unknown", int age = 0, bool isEndangered = false, string origin = "Unkown", int trunkLength = 0)
            // Calls the Animal (base class) constructor
            : base(name, species, age, isEndangered, origin)
        {
            // Initializes the TrunkLength property
            TrunkLength = trunkLength;
        }

        // Implementation of the makeSound method from the Isound interface
        public void makeSound()
        {
            // Prints the sound activity of the elephant with its trunk length
            Console.WriteLine($"{Name}sS trumpets loudly with its {TrunkLength} meter trunk!");
            // Prints the sound the elephant makes
            Console.WriteLine("Pawooo!");
        }
    }
}
