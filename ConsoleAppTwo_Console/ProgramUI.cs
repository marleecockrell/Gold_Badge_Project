using ConsoleAppTwo_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTwo_Console
{
    class ProgramUI
    {
        public ClaimsDataRepo _claimsData = new ClaimsDataRepo();
        public void Run()
        {
            SeedMenuList();
            Menu();

        }
        //menu method
        //1. see all claims
        //2. Take care of next claim
        //3. Enter a new claim
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a Menu Option: \n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewAllClaims();
                        break;
                    case "2":
                        ClaimsInQueue();
                        break;
                    case "3":
                        AddClaimToList();
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
        //see all claims
        private void ViewAllClaims()
        {
            Console.Clear();

            List<ClaimsData> listOfClaimsData = _claimsData.GetDataList();
            foreach (ClaimsData data in listOfClaimsData)
            {
                Console.WriteLine("ClaimID   Type   Description   Amount  DateOfAccident   DateOfClaim  IsValid");
                Console.WriteLine(data.ClaimID + "   " + data.TypeOfClaim + "   " + data.Description + "   " + data.ClaimAmount + "  " + data.DateOfIncident + "   " + data.DateOfClaim + "  " + data.IsValid);
            }
        }
        private void ClaimsInQueue(bool requiresAttention)
        {

            Console.WriteLine("Do you want to resolve the following claim now? (y/n)");
            ClaimsData data = _claimsData.GetContentByRequiresAttention(requiresAttention);
            if (data != null)
            {
                Console.WriteLine($"Claim ID:{data.ClaimID}\n" +
                    $"Type: {data.TypeOfClaim}\n" +
                    $"Description: {data.Description}\n" +
                    $"Amount: {data.ClaimAmount}\n" +
                    $"Date of Accident: {data.DateOfIncident}\n" +
                    $"Date of Claim: {data.DateOfClaim}\n" +
                    $"IsValid: {data.IsValid}");
            }
        }
        //enter a new claim
        private void AddClaimToList()

        {
            ClaimsData newClaim = new ClaimsData();
            Console.WriteLine("Enter the claim ID:");
            string claimIDAsString = Console.ReadLine();
            newClaim.ClaimID = int.Parse(claimIDAsString);

            Console.WriteLine("Enter the claim type:\n" +
                "1. Home\n" +
                "2. Car\n" +
                "3. theft");
            string claimTypeAsString = Console.ReadLine();
            int claimTypeAsInt = int.Parse(claimTypeAsString);
            newClaim.TypeOfClaim = (ClaimType)claimTypeAsInt;

            Console.WriteLine("Enter a claim description:");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Amount of damage:");
            string damageAsString = Console.ReadLine();
            newClaim.ClaimAmount = double.Parse(damageAsString);

            Console.WriteLine("Date of accident (MM/DD/YYYY Format):");
            newClaim.DateOfIncident = Console.ReadLine();

            Console.WriteLine("Date of claim (MM/DD/YYYY Format):");
            newClaim.DateOfClaim = Console.ReadLine();


            Console.WriteLine("Is the claim valid? (y/n)");
            string isValidAsString = Console.ReadLine().ToLower();

            if (isValidAsString == "y")
            {
                newClaim.IsValid = true;
            }
            else
            {
                newClaim.IsValid = false;
            }
        }

        private void SeedMenuList()
        {
            ClaimsData claimOne = new ClaimsData(1, ClaimType.Car, "Car accident on 465", 400.00, "04 / 25 / 2018", "04 / 27 / 2018", true, true);
            ClaimsData claimTwo = new ClaimsData(2, ClaimType.Home, "House fire in kitchen", 4000.00, "04/11/2018", "04/12/2018", true, false);
            ClaimsData claimThree = new ClaimsData(3, ClaimType.Theft, "stolen pancakes", 4.00, "04/27/2018", "06/03/2018", false, false);
            _claimsData.AddClaimToList(claimOne);
            _claimsData.AddClaimToList(claimTwo);
            _claimsData.AddClaimToList(claimThree);
        }
    }
}
