namespace Zoo
{
    public class Lion : Animal, Isound// Declares the Lion class, which inherits from Animal and implements the Isound interface
    {
        // Property to store the weight of the lion with a default value
        public double Weight { get; set; } = 0.0;

        // Constructor for Lion class that initializes properties and calls the base class constructor
        public Lion(string name = "Unknown", string species = "Unknown", int age = 0, bool isEndangered = false ,string origin ="Unkown", double weight= 0.0) :base(name,species,age,isEndangered,origin)
        {
            Weight = weight; // Initializes the Weight property
        }

        // Overrides the Feed method from Animal class to specify what the Lion is eating
        public override void Feed()
        {
            // Prints what the Lion is eating
            Console.WriteLine($"{Name} is eating a monkey");
        }

        // Implementation of the makeSound method from the Isound interface
        public void makeSound()
        {
            // Prints the sound the Lion makes
            Console.WriteLine("Raaawwwwrrrr!");
        }
        // Prints the sound the Lion makes
        public void ActualWeight()
        {
            // Prints the lion's weight
            Console.WriteLine($"{Name} weight :{Weight} kg" );
        }

        // Method specific to Lion class that simulates hunting behavior
        public void Hunt()
        {
            // Prints the lion's hunting activity
            Console.WriteLine($"{Name} is out and hunting for its prey!");
        }

    }
}
