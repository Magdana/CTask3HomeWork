Console.Write("enter first number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("enter second number: ");
int second = int.Parse(Console.ReadLine());

int divisor = 1;


int smalest = (first < second) ? first : second;
for (int i = 1; i <= smalest; i++)
{
    if (first % i == 0 && second % i == 0)
    {
        divisor = i;
    }
}

Console.WriteLine($"GCD of {first} and {second} is: {divisor}");