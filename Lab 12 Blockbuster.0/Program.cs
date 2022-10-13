using Lab_12_Blockbuster._0;

class Program
{
    static void Main(string[] args)
    {
      
        Blockbuster bb = new Blockbuster();


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        bool keepGoing = true;
        Console.WriteLine("Movie Night Playlist:");
        

        while (keepGoing)
        {
            Movie rental = bb.CheckOut();
            rental.Play();

            Console.WriteLine("=================================================================================");
            keepGoing = ContinueLoop("Play another movie?\n");
            Console.WriteLine("=================================================================================");
        }
        Console.WriteLine("=================================================================================");
        Console.WriteLine("Movie night complete.");
        Console.WriteLine("=================================================================================");

    }
    public static bool ContinueLoop(string question)
    {
        string response = GetInput(question);
        if (response.ToUpper() == "Y")
        {
            return true;
        }
        else if (response.ToUpper() == "Y")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Invalid input. Enter \"Y\" or \"N\".\n");
            return ContinueLoop(question);
        }
    }
    public static string GetInput(string prompt)
    {
        Console.Write(prompt);
        string output = Console.ReadLine();
        return output;
    }
}