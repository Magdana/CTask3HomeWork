//Console.Write("enter the number: ");
//int num = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i <= num / 2; i++)
//{
//    if (num % i == 0)
//    {
//        sum += i;


//    }

//}
//if (sum == num && num != 0) Console.WriteLine("the number is perfect");
//else Console.WriteLine("the number is not perfect");


int num = 1; 
bool foundPerfect = false;

while (num <= 10000)
{
    int sum = 0;
    for (int i = 1; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            sum += i;
        }
    }

    if (sum == num && num != 0)
    {
        Console.WriteLine($"Perfect number: {num}");
        foundPerfect = true; 
    }

    if (foundPerfect)
    {
        Console.WriteLine("Press Enter to continue or type '0' to exit.");
        string input = Console.ReadLine();

        if (input == "0")
        {
            break; 
        }

        foundPerfect = false; 
    }

    num++; 
}