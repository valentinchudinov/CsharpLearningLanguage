int Promt (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdRank(int number)
{
    while(number > 999)
    {
        number/=10;
    }
    return number % 10;
}
bool ValidateNumber(int number)
{
    if(number < 100)
    {
        System.Console.WriteLine("third digit is not");
        return false;
    }
    return true;
}
int number = Promt("Enter number >");
if(ValidateNumber(number))
{
    System.Console.WriteLine(GetThirdRank(number));
}