namespace Zoo
{   
    //Declares the Panther class, which inherits from Lion class 
    public class Panther: Lion 
    {   //Unique prorpety specific to Panther that represent its stealth attribute
        public string Stealth { get; set; } = "Unkown";
        //Constructor for Panther class that initialize properties and calls the base class constructor
        public Panther(string name = "Unknown", string species = "Unknown", int age = 0, bool isEndangered = false, string origin = "Unkown", double weight = 0.0, string stealth="Unknown") 
            :base(name, species, age, isEndangered,origin,weight)
        {
            //Initialize the Stealth property
            Stealth = stealth;
        }
        // Overriding of method Feed() inherited from the base class Anímal.
        //This method shows what the panther is eating.
        public override void Feed()
        {

            Console.WriteLine($"{Name} is eating a monkey");
        }
        //Method 
        public void MakeSound()
        {
            Console.WriteLine("GGGGGrrrrrroooooowwwwwllll!!");
        }
        //Method that makes the panther climb and eat a monkey if its hungry
        /* I choose to make it a boolean type (bool hungry = true;)
        to test  an if statement for later occation if i build something with a user input stating if the panter i hungry
        otherwise i could override the Feed()method and print that T-challa is eating a monkey*/

        public void Climb()
        {    // Assuming that the panther is always hungry
            bool hungry = true;
            //Checks if the panther is hungry
            if (hungry)
            {   //Prints that the panther is climbing a tree and thats its stealth is hard to detect.
                Console.WriteLine($"Look up! {Name} can climb up trees and her {Stealth} is hard to detect!");
                //Prints that the panter is eating a monkey.
                Console.WriteLine($"{Name} is now eating a monkey!!!");

            }
            else
            { // Prints that the panther is not hungry.
                Console.WriteLine($"{Name} is not hungry right now"); 
            }
           
        }
    }
}
