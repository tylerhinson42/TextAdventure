using System;
using System.Threading;

namespace TextAdventurePractice
{
    public class LivingRoomStories
    {
        public void firstLivingRoomStory(string characterName)
        {
            bool conditional = false;

            Console.WriteLine("This is the living room..");
            Console.WriteLine("You notice peculiar object around the room, do you want to explore these objects...");
            string response = Console.ReadLine().ToLower();
            Console.WriteLine($"{characterName}, Would you like to look behind the mirror?");
            string response1 = Console.ReadLine().ToLower();

            conditional = true;
            while (conditional)
            {
                
                if (response1 == "Yes")
                {
                    Console.WriteLine("You have found the only way out of this house..");
                    Console.WriteLine("Watch your 6 as you exit. You may never have this opportunity again. Should you choose to stay...");        
                }
                else if (response1 == "No" || response1 == "Maybe")
                {
                    Console.WriteLine("You must move to the Bedroom or your life is gravely at stake..");
                    Thread.Sleep(1500);
                    Console.WriteLine("You are now in the Bedromm..");    
                }
                else
                {
                    Environment.Exit(1);
                }
            }
        }
    }   
}
