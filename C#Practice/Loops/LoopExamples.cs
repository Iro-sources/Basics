using System;

class LoopExamples{
    static int workCount = 0;

    public static void Main(String[] args)
    {   //For Loop
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);

        }

        //nesting For Loop
        for (int i = 0; i < 100; i += 10)
        {
            for (int j = i; j < i + 10; j++)
            {
                Console.Write($" {j}");
            }

            Console.WriteLine();
        }


        //FiizBuzz
        for ( int i = 1; i<= 100; i++) {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FIZZBuzz");
            }

            else if (i % 3 == 0 )
            {
                Console.WriteLine("FIZZ");
            }

            else if (i % 5 == 0) 
            {
                Console.WriteLine("Buzz");
            }

            else
            {
                Console.WriteLine(i);
            }
        }

        //While loop

        bool condition = false;
        while (!condition) // this means as long as the condition is false the loop will run
        {   //this loop spins until condition is true
            Console.WriteLine("Working");
            DoSomeWork();

            condition = CheckCondition(); //assume check condition() returns a boolean
        }
        Console.WriteLine("The loop has ended.");
    }

        static void DoSomeWork()
        {
            workCount++;
        }

        static bool CheckCondition()
        {
            return workCount >= 5; 
        }
    }




