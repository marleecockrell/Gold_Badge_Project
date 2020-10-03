using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTwo_Repo
{
    public enum ClaimType
    {
        Home = 1,
        Car,
        Theft



    }
    public class ClaimsData
    {
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public string DateOfIncident { get; set; }
        public string DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public bool RequiresAttention { get; set; }

        public ClaimsData() { }
        public ClaimsData(int claimID, ClaimType typeOfClaim, string description, double claimAmount, string dateOfIncident, string dateOfClaim, bool isValid, bool requiresAttention)
        {
            ClaimID = claimID;
            TypeOfClaim = typeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
            RequiresAttention = requiresAttention;
        }

    }
}
