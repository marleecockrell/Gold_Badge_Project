using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppThree_Repo
{
    public enum Door
    {
        NA,
        A1,
        A2,
        A3,
        B4,
        B5,
        C6,
        C7

    }
    public class BadgeInfo
    {
        public int BadgeID { get; set; }
        public Door DoorName1 { get; set; }
        public Door DoorName2 { get; set; }
        public Door DoorName3 { get; set; }
        public string BadgeName { get; set; }

        public BadgeInfo() { }
        public BadgeInfo(int badgeID, Door doorName1, Door doorName2, Door doorName3, string badgeName)
        {
            BadgeID = badgeID;
            DoorName1 = doorName1;
            DoorName2 = doorName2;
            DoorName3 = doorName3;
            BadgeName = badgeName;
        }
       
        
    }
}
