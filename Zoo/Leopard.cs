namespace Zoo
{
    // Declares the Leopard class, which inherits from Lion
    public class Leopard : Lion
    {
        // Property to store the color of the leopard with a default value
        public string Color { get; set; } = "Unknown";
       
        
        public Leopard (string name = "Unknown", string species = "Unknown", int age = 0, bool isEndangered = false, string origin = "Unkown", double weight = 0.0, string color ="Unknown")
           : base(name, species, age, isEndangered,origin, weight)

        {
            // Initializes the Color property
            Color = color;
           
        }

        // Method that simulates the leopard making a sound
        public void MakeSound()
        {
            // Prints the sound the leopard makes
            Console.WriteLine("Ppppuuuuuurrrr");
        }

        // Method specific to Leopard class that describes its stealth ability
        public void RougeStealth()
        {
            // Method specific to Leopard class that describes its stealth ability
            Console.WriteLine($"{Name} is good att hiding, her {Color} is a good camouflage be aware of the shadows!");
        }
    }
}
