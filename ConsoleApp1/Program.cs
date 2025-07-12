using ConsoleApp1;
using System;

public class Program
{
    public string? s1;

    static void Main(string[] args)
    {
        int j = 20;
        for (int i = 0; i < 10; i++)
        {
            // int j = 30;
            j = 30;
            Console.WriteLine(j + i);
        }

        string s2 = "older version";
        var s3 = "c# 3";
        string s4 = new("C# 9");

        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);

        Console.Write(3 + 4);
        Console.Write(2 + 1);

        Console.WriteLine(3 + 4);
        Console.WriteLine(2 + 1);
        //Nullable Value Types
        //int? n1 = null;
        int? n1 = 10;
        if (n1.HasValue)
        {
            int n2 = n1.Value;
            Console.WriteLine(n2);
            Console.WriteLine(n1);
        }
        int n3 = 42;
        Console.WriteLine(n3);
        int? n4 = n3;

        //Nullable Reference Types
        String? s1 = null;
        if(s1 is not null)
        {
            string s5 = s1.ToUpper();
        }

        //If Else Statements
        Console.WriteLine("Type your height: ");
        decimal height;

        if (decimal.TryParse(Console.ReadLine(), out height))
        {
            if (height >= 120)
            {
                Console.WriteLine("You can ride");
            }
            else if (height < 100)
            {
                Console.WriteLine("You are too short to ride.");
            }
            else
            {
                Console.WriteLine("You might need an adult to accompany you.");
            }
        }
        else  // ✅ Now correctly outside the TryParse if-block
        {
            Console.WriteLine("Invalid number entered.");
        }

        Class2 c2 = new Class2();
        c2.SwitchSample(2);
        
        c2.SwitchSample2("us");
    }

   
}

