using System;
using System.Threading;

namespace TextAdventurePractice
{
    public class KitchenStories
    {
        private bool conditional;
        public string insidePantry;

        internal static void Enter()
        {
            Console.WriteLine("You have now entered the Kitchen");
        }

        public KitchenStories()
        {
            SubZero = true;
            CuttingBoard = true;
            Disposal = true;
            WaysOut = 1;
            WaysIn = 1;
            WayOut = insidePantry;
        }

        public bool SubZero { get; set; }
        public bool CuttingBoard { get; set; }
        public bool Disposal { get; set; }
        public int WaysOut { get; }
        public int WaysIn { get; }
        public string WayOut { get; set; }

        //public void firstKitchenStory(string characterName)
        //{
        //    bool conditional = true;

        //    Console.WriteLine("You are now in the Kitchen");
        //    Thread.Sleep(1500);
        //    Console.WriteLine("Would you like to look in the pantry?");
        //    string response = Console.ReadLine().ToLower();
        //    Console.WriteLine($"{characterName}, you've decided to look in the pantry.. Are you sure?");
        //    string response1 = Console.ReadLine().ToLower();

        //    conditional = true;
        //    if (response1 == "Yes")
        //    {
        //        Console.WriteLine("You have found the last way out of this house");
        //        Thread.Sleep(500);
        //        Console.WriteLine("Leave now before we change our minds..");
        //    }
        //    else if (response1 == "No"  || response1 == "Maybe")
        //    {
        //        Console.WriteLine("You must now proceed to the Basement, where your final fate awaits..");
        //        conditional = false;
        //    }
        //    else
        //    {
        //        Environment.Exit(1);
        //    }
        //}
    }
}

//using System;
//namespace TextAdventurePractice
//{
//    public class KitchenStories
//    {
       
//            public KitchenStories(int utensils, bool hasSecretDoor, int numEscapeDoors, string fridgeGreeting, string fireAlarm)
//            {
//                Utensils = utensils;
//                HasSecretDoor = hasSecretDoor;
//                NumEscapeDoors = numEscapeDoors;
//                FridgeGreeting = fridgeGreeting;
//                FireAlarm = fireAlarm;

//            }

//            public int Utensils { get; set; }
//            public bool HasSecretDoor { get; set; }
//            public int NumEscapeDoors { get; set; }
//            public string FridgeGreeting { get; set; }
//            public string FireAlarm { get; set; }

//            public void MakeFireAlarm(string fireAlarm)
//            {
//                FireAlarm = fireAlarm;
//                Console.WriteLine(fireAlarm);
//            }
//            public void MakeFireAlarm()
//            {
//                Console.WriteLine(FireAlarm);
//            }
        
//    }
//}
