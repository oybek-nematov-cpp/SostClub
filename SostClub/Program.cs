using System;

public class Computer
{
    public string Brend { get; set; }
    public string Protsessor { get; set; }
    public int Ram { get; set; }
    public int Disk { get; set; }

    public Computer(string brend, string protsessor, int ram, int disk)
    {
        Brend = brend;
        Protsessor = protsessor;
        Ram = ram;
        Disk = disk;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Brend: {Brend}");
        Console.WriteLine($"Protsessor: {Protsessor}");
        Console.WriteLine($"RAM: {Ram} GB");
        Console.WriteLine($"Disk: {Disk} GB");
    }
}

public class Laptop : Computer
{
    public int BatareyaQuvvati { get; set; }

    public Laptop(string brend, string protsessor, int ram, int disk, int batareya)
        : base(brend, protsessor, ram, disk)
    {
        BatareyaQuvvati = batareya;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Batareya Uzunligi: {BatareyaQuvvati} soat");
    }
}

public class SmartPhone : Computer
{
    public bool Sensorli { get; set; }

    public SmartPhone(string brend, string protsessor, int ram, int disk, bool sensorli)
        : base(brend, protsessor, ram, disk)
    {
        Sensorli = sensorli;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Sensorli ekran: {(Sensorli ? "Ha" : "Yo'q")}");
    }
}

class Program
{
    static void Main()
    {
        Computer pc = new Computer("HP", "Intel i5", 8, 512);
        Laptop laptop = new Laptop("Dell", "Intel i7", 16, 1024, 10);
        SmartPhone phone = new SmartPhone("Samsung", "Snapdragon", 6, 128, true);

        Console.WriteLine("---- KOMPYUTER ----");
        pc.ShowInfo();
        Console.WriteLine("\n---- NOUTBUK ----");
        laptop.ShowInfo();
        Console.WriteLine("\n---- SMARTFON ----");
        phone.ShowInfo();
    }
}
