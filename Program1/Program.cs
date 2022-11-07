internal class Program
{
    private static void Main(string[] args)
    {
        int userInput;
        do
        {
            DrawMenu();
            Console.WriteLine("Please select anumber between [0-3]: ");
            userInput = Int32.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        } while (true);
    }

    private static void DrawMenu()
    {
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