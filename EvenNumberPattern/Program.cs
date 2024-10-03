Console.Write("enter the number of lines: ");
int numb=int.Parse(Console.ReadLine());
int even = 2;
for(int i=1; i<=numb; i++)
{  
   if(even%2==0)
    {
        for(int j=1; j<=i; j++)
        {
            Console.Write(even + " ");
            even += 2;
        }
    }
    Console.WriteLine();
}