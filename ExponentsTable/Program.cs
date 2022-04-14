public class Program
{
    public static void Main()
    {
        Start:
        bool goAgain = true;
        bool Validation = true;
        while (goAgain == true)
        {
            var num = GetUserInput("Hi Please enter a integer");
            int numEntered = int.Parse(num);
            if (numEntered <= 0){
                Console.WriteLine("Sorry the integer you entered is incorrect please try again");
                goto Start;

            }
            if(numEntered > 1290)
            {
                Console.WriteLine("the integer you have input is too large to compute please enter a smaller integer please");
                goto Start;
            }
               
            Console.WriteLine(String.Format("{0,6}  {1,6}  {2,6}", "Number", "Squared", "Cubed"));
            Console.WriteLine("======" + "\t" + "=======" + "\t" + "======");
            for (int i = 0; i <= numEntered; i++)
            {
                double square = Math.Pow(i, 2);
                double cube = Math.Pow(i, 3);

                Console.WriteLine(String.Format("{0,6}  {1,6}  {2,6}", i ,  square , cube));
            }
            goAgain = RunAgain();
           
        }
        

    }
    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        return input;
    }
    public static bool RunAgain()
    {
        string answer = GetUserInput("Would you like to input another integer y/n?").ToLower();
        if(answer == "y")
        {
            return true;
        }
        else if(answer == "n")
        {
            return false;
        }
        else{
            Console.WriteLine("I'm sorry I didn't understand that");
            Console.WriteLine("Please input y or n");
            Console.WriteLine("Lets try again");
            return RunAgain();

        }
    }

}