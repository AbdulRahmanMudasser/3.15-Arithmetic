class Arithmetic
{
    static void Main(string[] args)
    {
        // declaring variables
        int firstNumber;
        int secondNumber;

        // prompting user and taking input for firstNumber
        Console.Write("Enter First Number:  ");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        // prompting user and taking input for secondNumber
        Console.Write("Enter Second Number:  ");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        // arithmetic operations
        int sum = firstNumber + secondNumber;
        int product = firstNumber * secondNumber;
        int division = firstNumber / secondNumber;    
        int difference = firstNumber - secondNumber;

        // displaying answers
        Console.WriteLine("Sum Of First And Second Number:  " + sum);
        Console.WriteLine("Product Of First And Second Number: " + product);
        Console.WriteLine("Division Of First By Second Number:  " + division);
        Console.WriteLine("Difference Of First And Second Number:  " + difference);
    }
}
