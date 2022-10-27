Console.WriteLine("Введите трехзначное число:");
int numA=int.Parse(Console.ReadLine()!);
int SecondDigit(int numA)
{
    int SecondDigit=(numA/10)%10;
    return SecondDigit;
}
Console.WriteLine(SecondDigit(numA));