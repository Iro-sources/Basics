using System;
using System.Reflection;

class Program{

    public static void Main(string[] args) {

        // ask the user to enter their height in cm.
        Console.WriteLine("Enter your height in Cm: ");
        //Read the height as a string from the console.
        //Try to convert the input to a decimal number using decimal.TryParse.
        if (!decimal.TryParse(Console.ReadLine(), out decimal height)){
            Console.WriteLine("Invalid height entered!");
                return;
        }
        //If the height is less than 120:
        if (height < 120)
        {
            Console.WriteLine("You are too young to ride.");
            return;
        }
        //Ask the user to enter their age.
        Console.WriteLine("Enter your age: ");
        //Read the age from the console.
        //Try to convert it using int.TryParse.
        if (!int.TryParse(Console.ReadLine(), out int age)) 
        {
            Console.WriteLine("Invalid age entered.");
            return;
        }

        //Use an int price variable.
        int price = 0;
        //If age is 18 or more, set price = 12.
        if(age >= 18){
            price = 12;
        }
        //Else if age is 12 or more, set price = 7.
        else if (age >= 12) {
            price = 7;
        }
        //Else(under 12), set price = 5.
        else
        {
            price = 5;
        }

        //Ask: “Do you want a photo? 'yes' or 'no'”
        Console.WriteLine("Do you want a photo? 'yes' or 'no' ");
        //Read input as a string.
        string photo = Console.ReadLine();
        //If the input is not null or empty and equals "yes"(case -insensitive):
        if (!string.IsNullOrEmpty(photo) && photo.ToLowerInvariant()== "yes") {
            //Add 3 to the price.
            price += 3;
            //Console.WriteLine($"Your total price is {price}");
        }
            Console.WriteLine($"Your total price is {price}");
        }
    
}