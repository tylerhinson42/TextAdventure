using System;
using System.Threading;

namespace TextAdventurePractice
{
    public class BedroomStories
    {
        private bool conditional;
        public string behindMirror;
        public BedroomStories()
        {
            MasterBed = true;
            Armoire = true;
            Dresser = true;
            WaysOut = 1;
            WaysIn = 2;
            WayOut = behindMirror;
            Console.WriteLine("Would you like to look behind the Mirror?");
            string response = Console.ReadLine().ToLower();

            conditional = true;
            while (conditional)
            {
                if (response == "Yes")
                {
                    Console.WriteLine("You have found the only way out of the Bedroom..");
                }
                else if (response == "No" || response == "Maybe")
                {
                    Console.WriteLine("You must now move into the Kitchen. Your options are running out..");
                    Thread.Sleep(500);
                }
            }
        }

        public bool MasterBed { get; set; }
        public bool Armoire { get; set; }
        public bool Dresser { get; set; }
        public int WaysOut { get; }
        public int WaysIn { get; }
        public string WayOut { get; set; }


        //public void firstBedroomStory(string characterName)
        //{
        //    bool conditional = true;

        //    Console.WriteLine("You are now in the Bedroom");
        //    Thread.Sleep(1500);
        //    Console.WriteLine("Would you like to look in the closet?");
        //    string response = Console.ReadLine().ToLower();
        //    Console.WriteLine($"{characterName}, you've decided to look in the closet.. Are you sure?");
        //    string response1 = Console.ReadLine().ToLower();

        //    conditional = true;
        //    if (response1 == "Yes")
        //    {
        //        Console.WriteLine("You have found the second way out of this house");
        //        Thread.Sleep(500);
        //        Console.WriteLine("Please proceed to safety, before it's too late");

        //        conditional = false;
        //    }
        //    else if (response1 == "No" || response1 == "Maybe")
        //    {
        //        Console.WriteLine("You must now move into the kitchen. You're getting closer to the end...");

        //        conditional = false;
        //    }
        //    else
        //    {
        //        Environment.Exit(1);
        //    }
        //}
    }
}
