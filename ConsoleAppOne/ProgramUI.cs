using ConsoleAppOne_Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    class ProgramUI
    {
        public MenuItemsRepo _menuRepo = new MenuItemsRepo();
        public void Run()
        {
            SeedMenuList();
            Menu();
        }
        private void Menu()
        {
            bool keeprunning = true;
            while (keeprunning)
            {

                //options display
                Console.WriteLine("Select a menu option\n" +
                    "1. Create a new menu item\n" +
                    "2. View All Menu Items\n" +
                    "3. Delete a menu item\n" +
                   "4.Exit");
                // User input
                string input = Console.ReadLine();
                //Eval user input
                switch (input)
                {
                    case "1":
                        CreateNewMenuItem();
                        break;
                    case "2":
                        ViewAllMenuItems();
                        break;
                    case "3":
                        DeleteMenuItem();
                        break;
                    case "4":
                        keeprunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid value");
                        break;
                }
                Console.WriteLine("Press a key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewMenuItem()
        {
            MenuItems newItem = new MenuItems();
            //Meal Number
            Console.WriteLine("Enter the meal number for the new item:");
            string mealNumberAsString = Console.ReadLine();
            newItem.MealNumber = int.Parse(mealNumberAsString);
            //Meal Name
            Console.WriteLine("Enter the name of the new item:");
            newItem.MealName = Console.ReadLine();
            //Meal Description
            Console.WriteLine("Enter a brief description of the new item:");
            newItem.MealDescription = Console.ReadLine();
            //Meal indredients
            Console.WriteLine("Enter the ingredients in the new item:");
            newItem.MealIngredients = Console.ReadLine();
            //Meal Price
            Console.WriteLine("Enter the price of the new item:");
            string priceAsString = Console.ReadLine();
            newItem.MealPrice = double.Parse(priceAsString);
            _menuRepo.AddMenuItemsToList(newItem);
        }
        private void ViewAllMenuItems()
        {
            Console.Clear();

            List<MenuItems> listOfMenuItems = _menuRepo.GetMenuItems();
            foreach (MenuItems items in listOfMenuItems)
            {
                Console.WriteLine($"Meal number: {items.MealNumber}\n" +
                    $"Meal Name: {items.MealName}\n" +
                    $"Meal Description: {items.MealDescription}\n" +
                    $"Meal Ingredients: {items.MealIngredients}\n" +
                    $"Meal Price: {items.MealPrice}");
            }
        }
        private void DeleteMenuItem()
        { 
            ViewAllMenuItems();
            Console.WriteLine("What menu item would you like to remove. Please enter the number");
            string items= Console.ReadLine();
            bool wasDeleted = _menuRepo.RemoveItemsFromList(items);
            if(wasDeleted)
            {
                Console.WriteLine("The Menu item was deleted");
            }
            else
            {
                Console.WriteLine("Item could not be deleted");
            }

        }

        private void SeedMenuList()
        {
            MenuItems burger = new MenuItems(1, "Burger Meal", "Signature hamburger meal with fries and a drink", "Hamburgr, bun, potatoes", 5.95);
            MenuItems salad = new MenuItems(2, "Salad Meal", "Fresh Garden Salad with choice of beverage", "Lettuce, tomatoes, cheese", 6.75);
            _menuRepo.AddMenuItemsToList(burger);
            _menuRepo.AddMenuItemsToList(salad);
        }
    }
}

