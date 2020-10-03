using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne_Repo
{
    public class MenuItemsRepo
    {
        public List<MenuItems> _listOfMenuItems = new List<MenuItems>();
        //create
        public void AddMenuItemsToList(MenuItems items)
        {
            _listOfMenuItems.Add(items);
        }
        //read
        public List<MenuItems> GetMenuItems()
        {
            return _listOfMenuItems;
        }
        //delete
        public bool RemoveItemsFromList(string mealName)
        {
            MenuItems items = GetItemsByName(mealName);
            if (items == null)
            {
                return false;
            }
            int initialCount = _listOfMenuItems.Count;
            _listOfMenuItems.Remove(items);

            if (initialCount > _listOfMenuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //helper
        public MenuItems GetItemsByName(string mealName)
        {
            foreach(MenuItems items in _listOfMenuItems)
            {
                if(items.MealName == mealName)
                {
                    return items;
                }
            }
            return null;
        }
    }
}
