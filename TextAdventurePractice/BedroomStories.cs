using System;
using System.Threading;

namespace TextAdventurePractice
{
    public class BedroomStories
    {
        public void firstBedroomStory(string characterName)
        {
            bool conditional = true;

            Console.WriteLine("You are now in the Bedroom");
            Thread.Sleep(1500);
            Console.WriteLine("Would you like to look in the closet?");
            string response = Console.ReadLine().ToLower();
            Console.WriteLine($"{characterName}, you've decided to look in the closet.. Are you sure?");
            string response1 = Console.ReadLine().ToLower();

            conditional = true;
            if (response1 == "Yes")
            {
                Console.WriteLine("You have found the second way out of this house");
                Thread.Sleep(500);
                Console.WriteLine("Please proceed to safety, before it's too late");

                conditional = false;
            }
            else if (response1 == "No" || response1 == "Maybe")
            {
                Console.WriteLine("You must now move into the kitchen. You're getting closer to the end...");

                conditional = false;
            }
            else
            {
                Environment.Exit(1);
            }
        }

    }
}
