using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal   DONE
            // give this class 4 members that all Animals have in common DONE


            // Create a class Bird   DONE
            // give this class 4 members that are specific to Bird    DONE
            // Set this class to inherit from your Animal Class   DONE

            // Create a class Reptile   DONE
            // give this class 4 members that are specific to Reptile    DONE
            // Set this class to inherit from your Animal Class    DONE

            Console.WriteLine("OUR PLANET");
            Console.WriteLine("");
            Console.WriteLine("Narrated by David Attenboro");
            Console.WriteLine("-------");



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values ----DONE
             */
            var sandpiper = new Bird();
            sandpiper.Age = 7;
            sandpiper.Legs = 2;
            sandpiper.IsExtinct = false;
            sandpiper.Diet = "Minnows";
            sandpiper.canFly = true;
            sandpiper.wingSpan = 6;
            sandpiper.beakSize = "tiny";
            sandpiper.itMigrates = false;


            Console.WriteLine($"Today we follow this sandpiper that is {sandpiper.Age} years old. As you can see, she has {sandpiper.Legs} legs and a wingspan of {sandpiper.wingSpan} inches. It is absolutely {sandpiper.IsExtinct} that she is extinct and she consumes {sandpiper.Diet} with her {sandpiper.beakSize} beak."
                + $"It is {sandpiper.canFly} that she can fly and {sandpiper.itMigrates} that she migrates.");

            Console.WriteLine("");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var turtle = new Reptile();
            turtle.Age = 17;
            turtle.Legs = 4;
            turtle.IsExtinct = false;
            turtle.Diet = "pizza";
            turtle.changesColors = false;
            turtle.isANopeRope = false;
            turtle.lengthOfTale = 4;
            turtle.hasScales = true;

            Console.WriteLine($"Now we move on to this turtle. He is {turtle.Age} years old and has {turtle.Legs} legs. It is definitely {turtle.IsExtinct} that he's extinct."
            + $"This particular turtle eats {turtle.Diet} and it is {turtle.changesColors} that he changes colors. Thank the Lord that it is {turtle.isANopeRope} that he is a nope rope."
            + $"His tale is {turtle.lengthOfTale} inches long and it is {turtle.hasScales} that he is covered in scales.");
        }
    }
}
