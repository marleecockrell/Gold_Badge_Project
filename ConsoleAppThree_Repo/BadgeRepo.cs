using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppThree_Repo
{
    public class BadgeRepo
    {
        private List<BadgeInfo> _listOfBadges = new List<BadgeInfo>();
        //create a new badge
        public void AddBadgeToList(BadgeInfo badge)
        {
            _listOfBadges.Add(badge);
        }
        //update doors on an existing badge, also removes door from badge
        public bool UpdateDoorAccess(int badgeID, BadgeInfo newBadge)
        {
            BadgeInfo oldBadge = GetBadgeByID(badgeID);
            if(oldBadge != null)
            {
                oldBadge.DoorName1 = newBadge.DoorName1;
                oldBadge.DoorName2 = newBadge.DoorName2;
                oldBadge.DoorName3 = newBadge.DoorName3;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //show a list of all badge numbers and door access
        public List<BadgeInfo> GetBadgeInfo()
        {
            return _listOfBadges;
        }
        public BadgeInfo GetBadgeByID(int badgeID)
        {
            foreach(BadgeInfo content in _listOfBadges)
            {
                if(badge.BadgeID == badgeID)
                {
                    return badge;
                }
            }
            return null;
        }
    }
}
