
 static bool Palindrom(string s)
{
    for (int i = 0; i < s.Length / 2; i++)
 
        if (s[i] != s[s.Length - i - 1])
            return false;
    return true;
}

Console.WriteLine("Введите число");
string CheckPalindrom = Console.ReadLine();

if(Palindrom(CheckPalindrom) == false)
{
Console.WriteLine("число не является полиндромом");
}
else
{
Console.WriteLine("число является полиндромом");
}
