// zadanie domowe dzien 4

string imię = "Krystian";
bool facet = false;
int wiek = 28;

if (facet == true)
{
    if (imię == "Krystian" && wiek == 28)
    {
        Console.WriteLine("Krystian, lat 28");
    }
    else if (imię != "Krystian" && wiek < 28)
    {
        Console.WriteLine("Facet poniżej 30 lat");
    }
}
else // mężczyzna
{
    if (wiek < 19)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else if (imię == "Kaśka")
    {
        Console.WriteLine("Czy mężczyzna może miec na imię Kaśka?");
    }
}

