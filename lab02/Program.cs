//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class ClassRoom
//{
//    private Puple[] puples;

//    public ClassRoom(params Puple[] puples)
//    {
//        this.puples = puples;
//    }

//    public void PrintPupleInfo()
//    {
//        Console.WriteLine("People info:");
//        for (int i = 0; i < puples.Length; i++)
//        {
//            Console.WriteLine($"People {i + 1}:");
//            puples[i].Study();
//            puples[i].Read();
//            puples[i].Write();
//            puples[i].Relax();
//            Console.WriteLine();
//        }
//    }
//}
//public class Puple
//{
//    public virtual void Study()
//    {
//        Console.WriteLine("People: Studying...");
//    }

//    public virtual void Read()
//    {
//        Console.WriteLine("People: Reading...");
//    }

//    public virtual void Write()
//    {
//        Console.WriteLine("People: Writing...");
//    }

//    public virtual void Relax()
//    {
//        Console.WriteLine("People: Relaxing...");
//    }
//}

//class ExcellentPuple : Puple
//{
//    public override void Study()
//    {
//        Console.WriteLine("ExcellentPeople: Studying very well!");
//    }

//    public override void Read()
//    {
//        Console.WriteLine("ExcellentPeople: Reading a lot of books!");
//    }

//    public override void Write()
//    {
//        Console.WriteLine("ExcellentPeople: Writing perfectly!");
//    }

//    public override void Relax()
//    {
//        Console.WriteLine("ExcellentPeople: resting a little");
//    }
//}
//class GoodPuple: Puple
//{
//    public override void Study()
//    {
//        Console.WriteLine("GoodPeople: Studying well!!");
//    }

//    public override void Read()
//    {
//        Console.WriteLine("GoodPeople: Reading books!");
//    }

//    public override void Relax()
//    {
//        Console.WriteLine("GoodPeople: Relaxing sometimes");
//    }
//}
//class BadPuple: Puple
//{
//    public override void Study()
//    {
//        Console.WriteLine("BadPeople: Not studying :(");
//    }

//    public override void Read()
//    {
//        Console.WriteLine("BadPeople: Not reading!!");
//    }

//    public override void Write()
//    {
//        Console.WriteLine("BadPeople: Don't like to write :<");
//    }

//    public override void Relax()
//    {
//        Console.WriteLine("BadPeople: Relaxing all the time");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Puple puple1 = new ExcellentPuple();
//        Puple puple2 = new GoodPuple();
//        Puple puple3 = new BadPuple();
//        Puple puple4 = new Puple();

//        ClassRoom classRoom = new ClassRoom(puple1, puple2, puple3, puple4);
//        classRoom.PrintPupleInfo();
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Vehicle
//{
//    private double x;
//    private double y;
//    private double price;
//    private double speed;
//    private int year;

//    public Vehicle(double x, double y, double price, double speed, int year)
//    {
//        this.x = x;
//        this.y = y;
//        this.price = price;
//        this.speed = speed;
//        this.year = year;
//    }

//    public void ShowInfo()
//    {
//        Console.WriteLine("Vehicle information:");
//        Console.WriteLine($"Coordinates: ({x}, {y})");
//        Console.WriteLine($"Price: {price}");
//        Console.WriteLine($"Speed: {speed}");
//        Console.WriteLine($"Year: {year}");
//    }
//}

//class Plane : Vehicle
//{
//    private double visota;
//    private int passengers;

//    public Plane(double x, double y, double price, double speed, int year, double visota, int passengers)
//        : base(x, y, price, speed, year)
//    {
//        this.visota = visota;
//        this.passengers = passengers;
//    }

//    public void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"visota: {visota}");
//        Console.WriteLine($"Passengers: {passengers}");
//    }
//}

//class Car : Vehicle
//{
//    public Car(double x, double y, double price, double speed, int year)
//        : base(x, y, price, speed, year)
//    {
//    }

//    public void ShowInfo()
//    {
//        base.ShowInfo();
//    }
//}

//class Ship : Vehicle
//{
//    private int passengers;
//    private string port;

//    public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
//        : base(x, y, price, speed, year)
//    {
//        this.passengers = passengers;
//        this.port = port;
//    }

//    public void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"Passengers: {passengers}");
//        Console.WriteLine($"Port: {port}");
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Plane plane = new Plane(100, 200, 100000, 500, 2010, 10000, 200);
//        plane.ShowInfo();

//        Console.WriteLine();

//        Car car = new Car(50, 100, 50000, 200, 2015);
//        car.ShowInfo();

//        Console.WriteLine();

//        Ship ship = new Ship(300, 400, 2000000, 100, 2020, 1000, "New York");
//        ship.ShowInfo();
//    }
//}

using System;

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter user access key: ");
        string userAccessKey = Console.ReadLine();

        DocumentWorker documentWorker;

        switch (userAccessKey)
        {
            case "pro":
                documentWorker = new ProDocumentWorker();
                break;
            case "exp":
                documentWorker = new ExpertDocumentWorker();
                break;
            default:
                documentWorker = new DocumentWorker();
                break;
        }

        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();
    }
}