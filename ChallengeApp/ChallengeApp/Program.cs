//Licznik cyfr w liczbie
int number = 1111666;
string cyfryWLiczbie = number.ToString();
char[] cyfry = cyfryWLiczbie.ToArray();
Console.WriteLine(cyfry);
int licznik0 = 0;
int licznik1 = 0;
int licznik2 = 0;
int licznik3 = 0;
int licznik4 = 0;
int licznik5 = 0;
int licznik6 = 0;
int licznik7 = 0;
int licznik8 = 0;
int licznik9 = 0;

foreach (char cyfra in cyfry)
{
    if (cyfra == '0')
    {
        licznik0++;
    }
    else if (cyfra == '1')
    {
        licznik1++;
    }
    else if (cyfra == '2')
    {
        licznik2++;
    }
    else if (cyfra == '3')
    {
        licznik3++;
    }
    else if (cyfra == '4')
    {
        licznik4++;
    }
    if (cyfra == '5')
    {
        licznik5++;
    }
    else if (cyfra == '6')
    {
        licznik6++;
    }
    else if (cyfra == '7')
    {
        licznik7++;
    }
    else if (cyfra == '8')
    {
        licznik8++;
    }
    else if (cyfra == '9')
    {
        licznik9++;
    }
}
Console.WriteLine("LIczba zer = " + licznik0);
Console.WriteLine("Liczba jedynek = " + licznik1);
Console.WriteLine("Liczba dwojek = " + licznik2);
Console.WriteLine("Liczba trojek = " + licznik3);
Console.WriteLine("Liczba czworek = " + licznik4);
Console.WriteLine("Liczba piatek = " + licznik5);
Console.WriteLine("Liczba szostek = " + licznik6);
Console.WriteLine("LIczba siodemek = " + licznik7);
Console.WriteLine("Liczba osemek = " + licznik8);
Console.WriteLine("Liczba dziewiatek = " + licznik9);