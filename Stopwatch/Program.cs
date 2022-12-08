Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Cronômetro");
    Console.WriteLine();

    Console.WriteLine("s = Segundo => 10s = 10 segundos");
    Console.WriteLine("m = Minuto => 1m = 1 minuto");

    Console.WriteLine();
    Console.WriteLine("0 = Sair");

    Console.WriteLine();
    Console.WriteLine("----------");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();

    if (data == "0")
        System.Environment.Exit(0);

    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if (type == 'm')
        multiplier = 60;

    PreStart(time * multiplier);
}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(500);
    Console.WriteLine("Set...");
    Thread.Sleep(500);
    Console.WriteLine("Go...");
    Thread.Sleep(1500);
    Start(time);
}

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Contagem finalizada");
    Thread.Sleep(2500);
    Menu();
}