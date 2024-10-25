namespace Zoo
{   
    //Declares the Monkey class , which inherits from Animal and impliments the Isound Interface

    public class Monkey :Animal,Isound
    {
        //A unique property specific to Monkey that represents its tail length with a default value of 0
        
        public int TailLength { get; set; } = 0;
        public Monkey(string name = "Unknown", string species = "Unknown", int age = 0, bool isEndangered = false, string origin = "Unkown", int tailLength = 0)
            // Calls the Animal (base class) constructor
            : base(name, species, age, isEndangered,origin) 
        {
            // Initializes the TailLength property
            TailLength = tailLength;
        }

        // Overrides the Feed method from Animal class to specify what the Monkey is eating
        public override void Feed()
        {
            // Prints what the Monkey is eating
            Console.WriteLine($"{Name} is eating bannana ");
        }
        // Implementation of the makeSound method from the Isound interface
        public void makeSound()
        {
            // Implementation of the makeSound method from the Isound interface
            Console.WriteLine("Oooh oohh  aah aah!");
        }

        // Method specific to Monkey class that describes the monkey's swinging ability
        public void Swing()
        {
            // Prints the monkey's swinging activity
            Console.WriteLine($"{Name} swings from tree to tree with its {TailLength}-inch tail!");
        }
        
    }
}
