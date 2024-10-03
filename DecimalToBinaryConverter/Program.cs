Console.Write("enter the number: ");
int num=int.Parse(Console.ReadLine());
string binary = "";
while (num > 0)
{
    binary = (num % 2).ToString() + binary;  
    num /= 2;
}

Console.WriteLine("Binary representation: " + binary);