// zadanie domowe dzien 4

string name = "Kaśka";
bool women = false;
int Age = 33;

if (women == true) //kobieta
{
    if (name == "Kaśka" && Age == 33)
    {
        Console.WriteLine("Kinga, lat 33");
    }
    else if (name != "Kinga" && Age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else // mężczyzna
{
    if (Age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else if (name == "Kaśka")
    {
        Console.WriteLine("Czy mężczyzna może miec na imię Kaśka?");
    }
}

