using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        int userInput = 5;
        do
        {
            DrawMenu();
            Console.WriteLine("Please select anumber between [0-3]: ");
            try
            {
                userInput = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                WriteError("***************** \n Wrong Value..... \n Please enter a number between [0-3] \n");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                //return;
            }


            switch (userInput)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    OldYoung();
                    break;
                case 2:
                    RepitationWord();
                    break;
                case 3:
                    WordSplit();
                    break;
                default:
                    break;
            }
        } while (true);
    }

    private static void WordSplit()
    {
        var sent = "";
        String[] words;
        try
        {
            WriteMessage("Please enter a sentences to split and print 3th word: ", ConsoleColor.Magenta);
            sent = Console.ReadLine();
            words = sent.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"{i+1}. {words[i]}");
            }
            WriteMessage($"The 3th word of your sentences is: {words[2]}", ConsoleColor.Green);
        }
        catch
        {
            WriteError("Wrong Value, Please enter a sentences.");
        }
        Console.ReadKey();
    }

    private static void RepitationWord()
    {
        int rep;
        WriteMessage("Please enter a word for repetition: ", ConsoleColor.Cyan);
        string userInput = Console.ReadLine();
        WriteMessage("How many times to repetition: ", ConsoleColor.Cyan);
        try
        {
            rep = Int32.Parse(Console.ReadLine());
        } 
        catch
        {
            rep = 10;
        }
        
        if (rep < 0 || rep > 100) { rep = 10; }
        
        for (int i = 0; i < rep-1; i++)
        {
            Console.Write($"{i}. {userInput}, ");
        }
        Console.Write($"{rep}. {userInput} ");
        Console.ReadKey();
    }

    private static void OldYoung()
    {
        int age, guest = 0;
        double price = 0;
        Console.WriteLine("How many guest do you have?");
        guest = Int32.Parse(Console.ReadLine());
        for(int i = 0; i < guest; i++)
        {
            Console.WriteLine($"Please enter an age, Person {i+1}:");
            try
            {
                age = Int32.Parse(Console.ReadLine());
                if (age > 0 && age <= 120)
                {
                    price = price + CheckAge(age);
                }
                else
                {
                    i--;
                    WriteError("Wrong Value...");
                }
            }
            catch
            {
                i--;
                WriteError("Wrong Value...");
            }
        }
        WriteMessage($"Total Value for {guest} guest is {price}", ConsoleColor.Cyan);
        Console.ReadKey();
    }

    private static void WriteError(string error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(error);
        Console.ForegroundColor = ConsoleColor.White;

    }

    private static void WriteMessage(string message, ConsoleColor c)
    {
        Console.ForegroundColor = c;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static int CheckAge(int age)
    {
        if (age < 20) { WriteMessage(">>>>> Ungdomspris: 80kr <<<<<", ConsoleColor.Yellow); return 80; }
        else if (age > 20 && age < 60) { WriteMessage(">>>>> Standardpris: 120kr <<<<<", ConsoleColor.Yellow); return 120; }
        else if (age > 60) { WriteMessage(">>>>> Pensionärspris: 90kr <<<<<", ConsoleColor.Yellow); return 90; }
        else return 0;
    }

    private static void DrawMenu()
    {
        Console.Clear();
        Console.WriteLine("#######################################");
        Console.WriteLine("############# Main Menu ############### \n");
        Console.WriteLine("Please select a number from menu.");
        Console.WriteLine("0. Exit Application");
        Console.WriteLine("1. Ungdom eller pensionär");
        Console.WriteLine("2. Upprepa tio gånger");
        Console.WriteLine("3. Det tredje ordet");
        Console.WriteLine("\n");
        Console.WriteLine("#######################################");

    }
}