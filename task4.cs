using System;

class Pet
{
    public enum TypeOfAnimal
    {
        Dog = 1,
        Cat,
        Bird
    }

    // Поля
    private string name;

    private int age;

    private TypeOfAnimal type;

    //Конструкторы
    public Pet(string name, int age, TypeOfAnimal type)
    {
        this.name = name;
        this.age = age;
        this.type = type;
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

    public TypeOfAnimal Type
    {
        set
        {
            type = value;
        }
        get
        {
            return type;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pet animal1 = new Pet("Барсик", 35, Pet.TypeOfAnimal.Dog);
        Pet animal2 = new Pet("Мурзик", 5, Pet.TypeOfAnimal.Cat);
        Console.WriteLine(animal1.Age);
        Console.WriteLine(animal1.Type);
        Console.WriteLine(animal1.Name);
        Console.WriteLine("-------------------");
        Console.WriteLine(animal2.Name);
        animal2.Name = "Мурка";
        Console.WriteLine(animal2.Name);
        Console.ReadKey();
    }
}
