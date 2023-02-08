/* Console.WriteLine("Input N");
int N = Convert.ToInt32(Console.ReadLine());

int i = 0;

if (N > 0)
{
while (i <= N)
{
    Console.WriteLine(i*i);
    i++;
}

}
else
Console.WriteLine("Input number > 0");

//for (int i = 1; i <=N; i++)
//{

//} */

/* int Method4(int N )
{
    
    for ( int i = 1; i < N; i++)
    {
        i = i * i;
    }
    return i;
}

string res = Method4(10, "z");
Console.WriteLine(res); */

int InputIntNumber(string numberName)
{
    Console.Write($"Input {numberName} integer number: ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write($"Input {numberName} integer number: " );
    }
    return number;
}

int a = InputIntNumber("luboe");
int [] array = new int [Math.Abs(a)];
for (int i = 1; i <= Math.Abs(a); i++)
{
    System.Console.WriteLine(i*i);
    array[i-1] = i * i;

}
for (int i = 0; i < Math.Abs(a); i++)
{
    System.Console.Write($" {array[i]} ");

}