using System;
using System.Threading;

namespace TextAdventurePractice
{
    public class BasementStories
    {
        private bool conditioanl;
        public string secretLever;
        public BasementStories()
        {
            CollapsingStairs = true;
            DeathTrapWasherDryer = true;
            PitOfSpikes = true;
            WaysOut = 0;
            _= WaysIn >= 0;
            WayOut = secretLever;
        }

        public bool CollapsingStairs { get; set; }
        public bool DeathTrapWasherDryer { get; set; }
        public bool PitOfSpikes { get; set; }
        public int WaysOut { get; }
        public int WaysIn { get; }
        public string WayOut { get; set; }

        //public  void firstBasementStories()
        //{
        //    bool conditional = true;

        //    Console.WriteLine("You have found your way to the Basement. Are you prepared to meet your end?");
        //    string response4 = Console.ReadLine().ToLower();

        //    conditional = true;
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
