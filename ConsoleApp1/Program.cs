using System;

public class Program
{
    public string s1;

    static void Main(string[] args)
    {
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

        // 🔥 This line is critical
        Class1 obj = new Class1();
    }
}
