using System;

class Information
{
    // Поля
    private string name;

    private string address;

    private int age;

    private int tel;

    //Конструкторы
    public Information(string name, string address, int age, int tel)
    {
        this.name = name;
        this.address = address;
        this.age = age;
        this.tel = tel;
    }

    // Свойства
    public string Name
    {
        set
        {
            name = value;
        }
        get
        {
            return name;
        }
    }

    public string Address
    {
        set
        {
            address = value;
        }
        get
        {
            return address;
        }
    }

    public int Age
    {
        set
        {
            age = value;
        }
        get
        {
            return age;
        }
    }

    public int Tel
    {
        set
        {
            tel = value;
        }
        get
        {
            return tel;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Information Me = new Information("Виктория", "г. №№№", 20, 123456);
            Information MyFriend = new Information("Иван", "г. №№№", 21, 51243);
            Information MyFriend2 =
                new Information("Марья", "г. №№№", 22, 32156);
            Console.WriteLine(Me.Name);
            Console.WriteLine(MyFriend.Age);
            Console.WriteLine(MyFriend2.tel);
            Console.ReadKey();
        }
    }
}
