Console.Write("enter binary number: ");
string binary = Console.ReadLine();
int decimalValue = Convert.ToInt32(binary, 2);
Console.WriteLine($"Decimal value: {decimalValue}");