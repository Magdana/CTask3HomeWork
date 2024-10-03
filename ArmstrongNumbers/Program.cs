//int num = int.Parse(Console.ReadLine());
//char[] arr = num.ToString().ToCharArray();
//int arrLength = arr.Length;
//int sum = 0;


//foreach (char c in arr)
//{
//    int charInt = c - '0';
//    sum += (int)Math.Pow(charInt, arrLength);
//}
//if (sum == num) Console.WriteLine("true");
//else Console.WriteLine("false");



//for (int i = 1; i <= 100000; i++)
//{
//    int num = i;
//    char[] arr = num.ToString().ToCharArray();
//    int arrLength = arr.Length;
//    int sum = 0;
//    foreach (char c in arr)
//    {
//        int charInt = c - '0';
//        sum += (int)Math.Pow(charInt, arrLength);
//    }

//    if (num == sum)
//    {
//        Console.WriteLine(sum);
//    }
//}


Console.WriteLine("press '*' to stop.");
int num = 1;

while (true)
{
    char[] arr = num.ToString().ToCharArray();
    int arrLength = arr.Length;
    int sum = 0;
    foreach (char c in arr)
    {
        int charInt = c - '0';
        sum += (int)Math.Pow(charInt, arrLength);
    }

    if (num == sum)
    {
        Console.WriteLine(sum);
    }

    num++;

    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey(true);

        if (key.KeyChar == '*')
        {
            Console.WriteLine("Program stopped.");
            break;
        }
    }
}