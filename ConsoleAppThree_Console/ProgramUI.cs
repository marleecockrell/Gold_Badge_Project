using ConsoleAppThree_Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppThree_Console
{
    class ProgramUI
    {
        //menu "Hello Admin, What would you like to do?
        //1. Add a badge.
        //2. Edit a badge
        //what is the badge number to update?
        //## has access to these doors:
        //What would you like to do: 1. remove a door, 2. add a door
        //>1 which door would you like to remove
        //3. List all badges.
        //Badge #   Door access
        //##        Doors
        public BadgeRepo badgeInfo = new BadgeRepo();
        public void Run()
        {
            seedBadgeList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a Menu Option: \n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge.\n" +
                    "3. List all badges.\n" +
                    "4. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddBadgeToList();
                        break;
                    case "2":
                        UpdateDoorAccess();
                        break;
                    case "3";
                        GetBadgeInfo();
                        break;
                    case "4":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu option");
                        break;
                }
                Console.WriteLine("Please press a key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //What is the number of the badge(find badge by ID)
        //What door does it need access to: 
        //more y reeat n to menu
        public void AddBadgeToList();
            {
                BadgeInfo newBadge = new BadgeInfo();
        Console.WriteLine("Enter the ID # of the new badge:");
                string claimIDAsString = Console.ReadLine();
        newBadge.ClaimID = int.Parse(claimIDAsString);

        Console.WriteLine("What would you like to name the badge?");
                newBadge.BadgeName = Console.ReadLine();

                Console.WriteLine("Please enter the name of the 1st door the badge needs to acces:\n +" +
                    "Format: A1, if no door access required type NA");
                string doorName1AsString = Console.ReadLine();
        newBadge.DoorName1 = (Door) doorName1AsString;

        Console.WriteLine("Please enter the name of the 2nd door the badge needs to acces:\n +" +
                    "Format: A1, if no door access required type NA");
                string doorName2AsString = Console.ReadLine();
        newBadge.DoorName1 = (Door) doorName2AsString;

        Console.WriteLine("Please enter the name of the 3rd door the badge needs to acces:\n +" +
                    "Format: A1, if no door access required type NA");
                string doorName3AsString = Console.ReadLine();
        newBadge.DoorName1 = (Door) doorName3AsString;

    }
    private void AddBadgeAccess();
    {
        
    }
}
}





        
    


