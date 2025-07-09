internal class Class1
{
    /// <summary>
    /// This is the constructor of the class1. 
    /// to execute this class I explicitly created and object inside the main method of the Program.cs class.
    /// </summary>
    public Class1()
    {
        Program program = new Program();
        program.s1 = "Hello from Class1!";
        Console.WriteLine(program.s1);
    }
}

