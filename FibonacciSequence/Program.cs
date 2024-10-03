int n = 100;
int first = 0, second = 1, third;

for (int i = 0; i < n; i++)
{
    if (i <= 1)
    {
        third = i;
    }
    else
    {
        third = first + second;
        first = second;
        second = third;
    }
    if (third > 100) break;
    Console.Write(third + " ");
}