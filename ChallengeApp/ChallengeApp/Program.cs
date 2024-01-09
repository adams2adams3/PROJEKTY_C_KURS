
var gender = "mezczyzna";
var age = 17;
var name = "Ewa";
if (gender == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (gender == "mezczyzna" && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}