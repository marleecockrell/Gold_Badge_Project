using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppThree_Repo
{
    class BadgeInfo
    {
        public int BadgeID { get; set; }
        public string DoorName { get; set; }
        public string BadgeName { get; set; }

        public BadgeInfo(int badgeID, string doorName, string badgeName)
        {
            BadgeID = badgeID;
            DoorName = doorName;
            BadgeName = badgeName;
        }
       
        
    }
}
