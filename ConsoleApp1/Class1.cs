internal class Class1
{
    /// <summary>
    /// This is the constructor of the class1. 
    /// to execute this class I explicitly created and object inside the main method of the Program.cs class.
    /// </summary>
    public Class1()
    {
        Program p = new Program();
        p.s1 = "Hello from Class1!";
        Console.WriteLine(p.s1);

        // Difference between variabl of class & instance of a class
        //Program p; // p i a Variable of the class
        //Variable of a class is a copy of the class that is not initialized. 

        //p = new Program(); // p is an Instance of a class
        //Instance of a class is the copy of the class that is initialized by using the new keyword. 

        //Program p = new Program();
        //p1 = p; //P2 is the refrence of the class, it is the pointer of p. They are allocated to the same memory address. 
    }
}

