using System;
using System.Reflection;

class Program{

    public static void Main(string[] args) {

        //user input for sum of two numbers
        Console.WriteLine("Enter a number: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a number: ");
        int b = int.Parse(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine("the sum of: " + a + " and " + b + " is : " + sum);

        /*Write a program that:
         Loops from 1 to 50
         For each number:
         Prints whether it's even or odd
         Every 10 numbers, prints a divider line
         Bonus: Format the output nicely
*/
        int number;
        int LineCounter = 0;

        for (number = 1; number <= 50; number ++)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine(number + " Even");
            }
            else{
                Console.WriteLine(number + " Odd");
            }

            LineCounter++;
            if (LineCounter == 10) {
                Console.WriteLine("---------------");
                LineCounter = 0;
            }
            
        }
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