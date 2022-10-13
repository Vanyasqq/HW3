
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

for(int i = 0; i <= N; i++ )
{
    double result = Math.Pow(i,2);
    if(i<N)
    {
        Console.Write(result + ", ");
    }
    else
    {
        Console.Write(result);
    }
}