using System;
using ConsoleAppOne_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppOne_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddMenuMethod_Test()
        {
            public MenuItemsRepo _listOfMenuItems = new MenuItemsRepo();
       
        int initialCount = _listOfMenuItems.Count;
        

            if (initialCount > _listOfMenuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
    }
}
