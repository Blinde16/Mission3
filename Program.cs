using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Mission3;

internal class Program
{
    private static void Main(string[] args)
    {
        //Creating a foodItem list to store all new fooditems created
        List<FoodItem> foodItems = new List<FoodItem>();

        bool exit = true;
        while (exit)
        {  
            //Intro & Navigation Line items before User Input
            Console.WriteLine("Welcome to the foodbank program");
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1: Add Food Items");
            Console.WriteLine("2: Delete Food Items");
            Console.WriteLine("3: Print List of Current Food Items");
            Console.WriteLine("4: Exit the Program");
            //Asking for User input
            if (!int.TryParse(Console.ReadLine(), out int action))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                continue; // Skip this iteration and loop again
            }

            if (action == 1)
            {
                //Getting user input to create new food Object
                Console.WriteLine("Please Enter the name of the new fooditem: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please Enter the category of the new fooditem: ");
                string category = Console.ReadLine();
                Console.WriteLine("Please Enter the quantity of the new fooditem (whole number): ");
                if (!int.TryParse(Console.ReadLine(), out int quantity))
                {
                    Console.WriteLine("Invalid input. Please enter a whole number for the quantity.");
                    continue; // Skip this iteration and prompt again
                }
                Console.WriteLine("Please Enter the expirationDate of the new fooditem: ");
                string expireDate = Console.ReadLine();

                //creating instance of new foodobject from constructor
                FoodItem newItem = new FoodItem(name, category, quantity, expireDate);

                foodItems.Add(newItem);
                Console.WriteLine("Food Item added successfully");
            }
            else if (action == 2)
            {
                //Display the list of Fooditems already created in the system to delete
                if (foodItems.Count > 0)
                {
                    for (int i = 0; i < foodItems.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: Food Name: {foodItems[i].Name}, Category: {foodItems[i].Category}, Quantity: {foodItems[i].Quantity}, Expiration Date: {foodItems[i].ExpireDate}");
                    }

                    //Ask for UserInput on what they wish to remove
                    Console.WriteLine("Type the number of the fooditem that you wish to delete:");
                    if (int.TryParse(Console.ReadLine(), out int response) && response > 0 && response <= foodItems.Count)
                    {
                        //Removing fooditem based on user response
                        foodItems.RemoveAt(response - 1);
                        Console.WriteLine("Food Item removed successfully");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. No item deleted.");
                    }
                }
                else
                {
                    Console.WriteLine("There are not items in the list yet...");
                }
            }
            else if (action == 3)
            {
                if (foodItems.Count > 0)
                {
                    //Display the list of Fooditems already created in the system
                    for (int i = 0; i < foodItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: Food Name: {foodItems[i].Name}, Category: {foodItems[i].Category}, Quantity: {foodItems[i].Quantity}, Expiration Date: {foodItems[i].ExpireDate}");
                }
                }
                else
                {
                    Console.WriteLine("There are not items in the list yet...");
                }
            }
            else if (action == 4)
            {
                //Exiting the program 
                Console.WriteLine("Are you sure you want to exit the program? (Yes or No)");
                string isExit = Console.ReadLine();
                if (isExit.ToLower() == "yes")
                {
                    exit = false;
                }
                else
                {
                    exit = true;
                }
            }
            else
            {
                Console.WriteLine("Oops... You need to pick a number between 1 and 4");
            }
        }
        
    }
}