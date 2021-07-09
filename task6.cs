using System;

class Car
{
    // Поля
    private int year_model;

    private string make;

    private int speed;

    //Конструкторы
    public Car(int year_model, string make, int speed = 0)
    {
        this.year_model = year_model;
        this.make = make;
        this.speed = speed;
    }

    // Свойства
    public int Year_model
    {
        set
        {
            year_model = value;
        }
        get
        {
            return year_model;
        }
    }

    public string Make
    {
        set
        {
            make = value;
        }
        get
        {
            return make;
        }
    }

    public int Speed
    {
        set
        {
            speed = value;
        }
        get
        {
            return speed;
        }
    }

    // Методы
    public int accelerate()
    {
        this.speed += 5;
        return this.speed;
    }

    public int brake()
    {
        this.speed -= 5;
        return this.speed;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car(1982, "BMW");
        for (int i = 0; i < 5; i++)
        {
            myCar.accelerate();
            Console.WriteLine(myCar.Speed);
        }
        for (int i = 0; i < 5; i++)
        {
            myCar.brake();
            Console.WriteLine(myCar.Speed);
        }

        Console.ReadKey();
    }
}
