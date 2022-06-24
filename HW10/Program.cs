using HW10.Classes;

internal class Program
{
    private static void Main(string?[] args)
    {

        int firstNum;
        int secondNum;
        int divider;
        AskNumber(out firstNum, out secondNum, out divider);
        SecondClass.Calc(FirstClass.powDeleg, firstNum, secondNum);
        FirstClass.Show(SecondClass.Result(divider));
    }

    private static void AskNumber(out int firstNum, out int secondNum, out int divider)
    {
        Console.WriteLine($"Please input the first number");
        string firstNumStr = Console.ReadLine();
        bool isInt1 = int.TryParse(firstNumStr, out firstNum);

        Console.WriteLine($"Please input the second number");
        string secondNumStr = Console.ReadLine();
        bool isInt2 = int.TryParse(secondNumStr, out secondNum);

        Console.WriteLine($"Please input the divider");
        string dividerStr = Console.ReadLine();
        bool isInt3 = int.TryParse(dividerStr, out divider);

        if(!isInt1 || !isInt2 || !isInt3)
        {
            WrongInput();
        }
    }

    private static void WrongInput()
    {
        Console.WriteLine("You did not input an integer! Please try again");
    }
}