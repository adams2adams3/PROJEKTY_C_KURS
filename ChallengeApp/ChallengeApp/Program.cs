//Licznik cyfr w liczbie
int number = 1111666000;
string digitsInNumber = number.ToString();
char[] digits = digitsInNumber.ToArray();
Console.WriteLine(digits);
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char digit in digits)
{
    if (digit == '0')
    {
        counter0++;
    }
    else if (digit == '1')
    {
        counter1++;
    }
    else if (digit == '2')
    {
        counter2++;
    }
    else if (digit == '3')
    {
        counter3++;
    }
    else if (digit == '4')
    {
        counter4++;
    }
    if (digit == '5')
    {
        counter5++;
    }
    else if (digit == '6')
    {
        counter6++;
    }
    else if (digit == '7')
    {
        counter7++;
    }
    else if (digit == '8')
    {
        counter8++;
    }
    else if (digit == '9')
    {
        counter9++;
    }
}
Console.WriteLine("Liczba zer = " + counter0);
Console.WriteLine("Liczba jedynek = " + counter1);
Console.WriteLine("Liczba dwojek = " + counter2);
Console.WriteLine("Liczba trojek = " + counter3);
Console.WriteLine("Liczba czworek = " + counter4);
Console.WriteLine("Liczba piatek = " + counter5);
Console.WriteLine("Liczba szostek = " + counter6);
Console.WriteLine("LIczba siodemek = " + counter7);
Console.WriteLine("Liczba osemek = " + counter8);
Console.WriteLine("Liczba dziewiatek = " + counter9);