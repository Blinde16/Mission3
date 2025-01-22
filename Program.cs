using System.Security.Cryptography.X509Certificates;
using Mission3;

internal class Program
{
    private static void Main(string[] args)
    {
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
            int action = Console.ReadLine();

            if (action == 1)
            {
                //Getting user input to create new food Object
                Console.WriteLine("Please Enter the name of the new fooditem: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please Enter the category of the new fooditem: ");
                string category = Console.ReadLine();
                Console.WriteLine("Please Enter the quantity of the new fooditem (whole number): ");
                int quantity = Console.ReadLine();
                Console.WriteLine("Please Enter the expirationDate of the new fooditem: ");
                string expireDate = Console.ReadLine();

                //creating instance of new foodobject from constructor
                FoodItem FI1 = new FoodItem(name, category, quantity, expireDate);
            }
            else if (action == 2)
            {
                Console.WriteLine("type the number of the fooditem that you wish to delete:");
                //Display the list of Fooditems already created in the system to delete
            }
            else if (action == 3)
            {
                //Display the list of Fooditems already created in the system
            }
            else if (action == 4)
            {
                //Exiting the program 
                Console.WriteLine("Are you sure you want to exit the program? (Yes or No)");
                string isExit = Console.ReadLine();
                if (isExit.ToLower() == 'yes')
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