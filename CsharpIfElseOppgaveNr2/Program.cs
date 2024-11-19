// See https://aka.ms/new-console-template for more information
int num1 = 5;
int num2 = 5;





int CompareNumbers()
{
    if (num1 != num2)
    {
        return num1 + num2;
    }

    else if (num1 == num2)
    {
        return num1 * num2;
    }
    else
    {
        return 0;
    }
    
}
void ResultMessage()
{ CompareNumbers();

    if (CompareNumbers() < 12)
    {   
        Console.WriteLine($"They were unequal and returned: {CompareNumbers()}");
    }
    else if (CompareNumbers() > 24)
    {
        Console.WriteLine($"They were equal and multiplied: {CompareNumbers()}");
    }
}
    void CreateResult()
{
    var userInput = Console.ReadLine();

    if (userInput == "Equal")
    {
        num2 = 5;
    }
    else if (userInput == "Not Equal")
    {
        num2 = 6;
    }
    ResultMessage();
}
CreateResult();
    