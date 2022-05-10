using System;

#fuction main
public static void Main()
{
    #input a option to choose
    Console.WriteLine("Enter a number to choose an option");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");
    
    #variable to store the option
    int option = Convert.ToInt32(Console.ReadLine());

    #switch statement to choose an option
    switch (option)
    {
        #case 1
        case 1:

            #run a program.exe 
            System.Diagnostics.Process.Start("program.exe");
            #input a number
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

        default:
            #print a message
            Console.WriteLine("You have entered an invalid option");
            break;

    
    }
}


