using GeneriekeCollecties;

Stapel<string> stapel = new Stapel<string>();
char keuze = '0';

do
{
    Console.WriteLine("Kies achtereenvolgens: ");
    Console.WriteLine("0 Stoppen");
    Console.WriteLine("1 Opzetten");
    Console.WriteLine("2 Afhallen");
    Console.WriteLine("3 De Lijst tonnen");
    Console.WriteLine("4 Leeg maken");
    Console.Write("Geef je keuze en druk [enter]:");
    keuze = Console.ReadLine()[0];
    Console.WriteLine();

    switch (keuze)
    {
        case '0':
            Console.WriteLine("afsluiten");
            break;

        case '1':
            Console.Write("Wat wil je stappelen:");
            stapel.Opzetten(Console.ReadLine());
            break;

        case '2':
            Console.WriteLine("Het eerste product in de container is: " + stapel.Afhallen());
            break;

        case '3':
            Console.WriteLine("De lijst van de producten: ");
            Console.Write(stapel.ToString());
            Console.WriteLine();
            break;

        case '4':
            stapel.LeegMaken();
            Console.WriteLine("De sapel word leeg gemaakt");
            break;
    }
} while (keuze != '0');