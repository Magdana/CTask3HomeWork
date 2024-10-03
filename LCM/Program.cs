Console.Write("enter first number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("enter second number: ");
int second = int.Parse(Console.ReadLine());

int bigest = (first > second) ? first : second;
while (true)
{
    if (bigest % first == 0 && bigest % second == 0)
    {
        Console.WriteLine($"LCM of {first} and {second} is: {bigest}");
        break;
    }
    bigest++;
}
