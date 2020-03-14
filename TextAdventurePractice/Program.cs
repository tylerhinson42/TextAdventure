using System;
using System.Threading;

namespace TextAdventurePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool conditional = true;
          
            Console.WriteLine("Are you prepared to enter?");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Console.WriteLine("Welcome to The JackedUp Manor");
            }
            else if (response == "no" || response == "maybe")
            {
                Console.WriteLine("Come back when your soul is prepared...");
                Environment.Exit(1); //Terminates the program
            }
            Thread.Sleep(1500); //1.5 seconds counted in milliseconds

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkRed; //Once it gets to this line, everything thereafter will be red until changed back
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Welcome {name}, My name is Lucious.");


            while (conditional)
            {
                Console.WriteLine("Which room would you like to see first: Living Room, Bedroom, Kitchen, or the Basement");
                response = Console.ReadLine().ToLower();
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
            }

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            //conditional = true;
            //if(response == "living room")
            //{
                //Console.WriteLine("You have chosen to enter the Living Room. Would you like to look behind the mirror?");
                //Thread.Sleep(1500);
                //string response1 = Console.ReadLine();
                //if (response == "Yes")
                //{
                //    Console.WriteLine("You have found the only way out of this house..");
                //    Console.WriteLine("Watch your 6 as you exit. You may never have this opportunity again. Should you choose to stay...");
                //    conditional = false;

                //}
                //else if (response1 == "no" || response1 == "maybe") 
                //{                   
                //    Console.WriteLine("You must move to the Bedroom or your life is gravely at stake..");
                //    conditional = false;
                //}
                //else
                //{
                //    Environment.Exit(1);
                //}
                LivingRoomStories livingRoom = new LivingRoomStories();
                livingRoom.firstLivingRoomStory(name);
            //}

            //while (conditional1)
            //{
            //    Console.WriteLine("You are now in the Bedroom. Would you like to look behind the mirror?");
            //    Thread.Sleep(1500);
            //    string response2 = Console.ReadLine();
            //    if (response2 == "Yes")
            //    {
            //        Console.WriteLine("You have found the second way out of this house");
            //        Console.WriteLine("Congratulations. You have survived JackedUp Manor.");
            //        conditional1 = false;
                    
            //    }
            //    else if (response2 == "No" || response2 == "Maybe")
            //    {
            //        Console.WriteLine("You must now move to the Kitchen. Your life is in danger!");
            //        conditional1 = false;
            //    }
            //    else
            //    {
            //        Environment.Exit(1);
            //    }
            //}

            //while (conditional2)
            //{
            //    Console.WriteLine("You are now in the Kitchen. Your options are running out.. Would you like to look in the pantry?");
            //    Thread.Sleep(1500);
            //    string response3 = Console.ReadLine();
            //    if (response3 == "Yes")
            //    {
            //        Console.WriteLine("You have chosen your last way out of this house. Please proceed before it consumes you..");
            //        Console.WriteLine("You have made it safely out of the house of horrors, aka, JackedUp Manor.");
            //        conditional2 = false;
                    
            //    }
            //    else if (response3 == "No" || response3 == "Maybe")
            //    {
            //        Console.WriteLine("You must now proceed to the Basement. May God be with you on your journey..");
            //        conditional2 = false;
            //    }
            //    else
            //    {
            //        Environment.Exit(1);
            //    }

            //}

            
            //{
            //    Console.WriteLine("You have found your way to the Basement. Are you prepared to meet your end?");
            //    string response4 = Console.ReadLine();
            //    if (response4 == "Yes" || response4 == "No" || response4 == "Maybe")
            //    {
            //        Console.WriteLine("Your choices have run out. It's too late for your soul..");
            //        Thread.Sleep(1500);
            //        Console.WriteLine("Prepare to enter the pit.. Godspeed...");
            //        Console.WriteLine("You have succumed to this place...... And have now perished forever.");
            //        Environment.Exit(1);
            //    }
            //}                      
        }    
    }
}
