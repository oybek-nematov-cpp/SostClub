using System;
using System.Runtime.CompilerServices;

public class Car
{
    public string Brend { get; set; }
    public string Name { get; set; }
    public int Speed { get; set; }
    public int Price { get; set; }

    public Car(string brend, string name, int speed, int price)
    {
        Brend = brend;
        Name = name;
        Speed = speed;
        Price = price;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Brend: {Brend}");
        Console.WriteLine($"Nomi: {Name}");
        Console.WriteLine($"Tezligi: {Speed} km/h");
        Console.WriteLine($"Narxi: {Price} $");
    }
}

public class PassangerCar : Car
{
    public int Soni { get; set; }

    public PassangerCar(string brend, string name, int speed, int price, int soni)
        : base(brend, name, speed, price)
    {
        Soni = soni;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Yo'lovchilar soni: {Soni} nafar");
    }
}

public class CargoCar : Car
{
    public bool YukUchun { get; set; }

    public CargoCar(string brend, string name, int speed, int price, bool yuk)
        : base(brend, name, speed, price)
    {
        YukUchun = yuk;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Faqat yuk uchun: {(YukUchun ? "Ha" : "Yo'q")}");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Mersedes", "Mers", 200, 5000);
        PassangerCar pcar = new PassangerCar("Mersedes", "Mersedes Bus", 180, 10000, 25);
        CargoCar cargo = new CargoCar("Isuzu", "Isuzu200", 220, 1200000, true);

        Console.WriteLine("---- Car ----");
        car.ShowInfo();
        Console.WriteLine("\n---- PassangerCar ----");
        pcar.ShowInfo();
        Console.WriteLine("\n---- CargoCar ----");
        cargo.ShowInfo();
    }
}
