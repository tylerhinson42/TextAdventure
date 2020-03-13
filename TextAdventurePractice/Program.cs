using System;
using System.Threading;

namespace TextAdventurePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Are you prepared to enter?");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Console.WriteLine("Welcome to The Furnace");
            }
            else if (response == "no" || response == "maybe")
            {
                Console.WriteLine("Come back when your soul is prepared...");
                Environment.Exit(1); //Terminates the program
            }
            Thread.Sleep(1500); //1.5 seconds counted in milliseconds

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red; //Once it gets to this line, everything thereafter will be red until changed back
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Welcome {name}, My name is Gerard");
            Console.WriteLine("Which room would you like to see first: Living Room, Bedroom, Kitchen, or the Basement");
            response = Console.ReadLine().ToLower();

            bool conditional = true;
            while (conditional)

                switch (response)
                {
                    case "living room":
                        Console.WriteLine("Very well, we will look at the living room first");
                        conditional = false;
                        break;
                    case "bedroom":
                        Console.WriteLine("Very well, we will look at the bedroom first");
                        conditional = false;
                        break;
                    case "kitchen":
                        Console.WriteLine("Very well, we will look at the kitchen first");
                        conditional = false;
                        break;
                    case "basement":
                        Console.WriteLine("I understand, but I urge you to make another selection");
                        count++;
                        if (count >= 2)
                        {
                            Console.WriteLine("As you wish....");
                            Thread.Sleep(1500);
                            Console.WriteLine("A hole opens up in the floor... you have fallen into a pit of spikes, and died a horrible death");
                            Environment.Exit(1);
                        }
                        break;
                }
            if (response != "living room" && response != "bedroom" && response != "kitchen" && response != "basement")
            {
                Console.WriteLine("Please make a proper selection...");
            }


            {
                Console.WriteLine("You have chosen to enter the living room. Would you like to look behind the mirror?");
                Thread.Sleep(1500);
                string response1 = Console.ReadLine();
                if (response == "Yes")
                {
                    Console.WriteLine("You have found the only way out of this house..");
                }
                else if (response1 == "no" || response == "maybe")
                {
                    Console.WriteLine("You must move to the bedroom or your life is gravely at stake..");
                }
            }
            {
                Console.WriteLine("You are now in the bedroom. Would you like to look behind the mirror?");
                Thread.Sleep(1500);
                string response2 = Console.ReadLine();
                if (response2 == "Yes")
                {
                    Console.WriteLine("Uou have found the second way out of this hosue");
                }
                else if (response2 == "No" || response2 == "Maybe")
                {
                    Console.WriteLine("You must now move to the kitchen. Your life is in danger!");
                }
            }

            {
                Console.WriteLine("You are now in the kitchen. Your options are running out.. Would you like to look in the pantry?");
                Thread.Sleep(1500);
                string response3 = Console.ReadLine();
                if (response3 == "Yes")
                {
                    Console.WriteLine("You have chosen your last way out of this house. Please proceed before it consumes you..");
                }
                else if (response3 == "No" || response3 == "Maybe")
                {
                    Console.WriteLine("You must now proceed to the basement. May God be with you on your journey..");
                }

            }

            {
                Console.WriteLine("You have found your way to the basement. Are you prepared to meet your end?");
                string response4 = Console.ReadLine();
                if (response4 == "Yes" || response4 == "No" || response4 == "Maybe")
                {
                    Console.WriteLine("Your choices have run out. It's too late for your soul..");
                    Thread.Sleep(1500);
                    Console.WriteLine("Prepare to enter the pit.. Godspeed...");
                    Console.WriteLine("You have succumed to this place...... And have now perished forever.");
                    Environment.Exit(1);
                }
            }
            
            
        }    
    }
}
