namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of a Lion with deafult values
            Lion simba = new Lion(); // Parameters are empty to test if the default values are working.
            // Calling DiplayInfo method to print Simbas values 
            simba.DisplayInfo();
            //Calling ActualWeight metod to print Simba´s weight
            simba.ActualWeight();
            // simulate Simba hunting
            simba.Hunt();
            // Simulate feeding Simba
            simba.Feed();
            // Simulate Simba making a sound
            simba.makeSound();

            // For better outpu visual in the console
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            // Instantiates a Panther with specified values
            Panther blackPanther = new Panther("T´Challa","Panther", 7,true,"Africa/America",185.6, "Stealth");
            // Show Black Panther's details
            blackPanther.DisplayInfo();
            // Simulate Black Panther climbing
            blackPanther.Climb();
            // Simulate Black Panther making a sound
            blackPanther.makeSound();

            // For better output visual in the console
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            // Instantiates a Leopard with specified values
            Leopard leopard = new Leopard("Nyota", "Leopard", 10, true,"Africa",177.7,"blend seamlessly");
            // Show Leopard's details
            leopard.DisplayInfo();
            // Simulate Leopard's stealth
            leopard.RougeStealth();
            // Simulate Leopard making a sound
            leopard.makeSound();


            // For better output visual in the console
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            // Simulate Leopard making a sound
            Monkey george = new Monkey("George","Monkey",6,false,"Africa/Asia",15);
            // Show Monkey's details
            george.DisplayInfo();
            // Simulate Monkey swinging
            george.Swing();
            // Simulate feeding George
            george.Feed();
            // Simulate George making a sound
            george.makeSound();

            // For better output visual in the console
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            // Instantiates an Elephant with specified values
            Elephant jumbo = new Elephant("Jumbo","Elephant",86,true,"Africa/Asia",7);
            // Show Elephant's details
            jumbo.DisplayInfo();
            // Simulate feeding Jumbo
            jumbo.Feed();
            // Simulate feeding Jumbo
            jumbo.makeSound();



        }
    }
}
