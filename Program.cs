// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Enter Weather:");


string weatherStatus = Console.ReadLine();

if (weatherStatus == "gunesli")
    Console.WriteLine("Eynek tax");
else if (weatherStatus == "yagisli")
    Console.WriteLine("zontik gotur");
else if (weatherStatus == "soyuq")
    Console.WriteLine("qalin gey");
else
    Console.WriteLine("duzgun qeyd etmemisiniz");
