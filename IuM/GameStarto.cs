// File1.cs
class GameStarto
{
    static void Main()
    {
        string input;

        while (true)
        {
            Console.Write("Enter a string: ");
            input = Console.ReadLine();

            if (input == "exit")
            {
                break;
            }

            Console.WriteLine("You entered: " + input);
        }
    }
}