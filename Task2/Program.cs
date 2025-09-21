using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ob1 = new Car("Koenigsegg", "2000HP", 545);
            Car ob2 = new Car("Rimac", "ELECTRO", 466);
            Car ob3 = new Car("Koenigsegg", "2000HP", 545);
            Console.WriteLine(ob1.Equals(ob2));//Не одинаковые -> False
            Console.WriteLine(ob1.Equals(ob3));//Одинаковые -> True

            Console.WriteLine("\n");//Отделить вывод в консоли визуально

            CarsCatalog catalog = new CarsCatalog();//Создаем объект класса CarsCatalog
            catalog.Add(new Car("Toyta", "2jz", 332));//Заполняем коллекцию cars автомобилями
            catalog.Add(new Car("Suzuki", "0123", 180));
            catalog.Add(new Car("Porshe", "8.8mm", 332));

            for (int i = 0; i < 3; i++) { Console.WriteLine(catalog[i]); }//Работа индексатора
        }
    }
}
class CarsCatalog
{
    private List<Car> cars;

    public void Add(Car car)
    {
        cars.Add(car);
    }

    public CarsCatalog()
    {
        cars = new List<Car>();
    }

    public string this[int index]
    {
        get
        {
    
            if (index >= 0 && index < cars.Count)
                return $"Name: {cars[index].Name}; Engine: {cars[index].Engine}"; // возвращаем по индексу строку с названием и двигателем
            else
                throw new ArgumentOutOfRangeException(); // иначе генерируем исключение
        }
    }

}


class Car : IEquatable<Car>
{
    public string Name { get; set; }
    public string Engine { get; set; }
    public int MaxSpeed { get; set; }
    public Car() { }
    public Car(string name, string engine, int speed)
    {
        this.Name = name;
        this.Engine = engine;
        this.MaxSpeed = speed;
    }

    public override string ToString()
    {
        return Name;
    }

    public bool Equals(Car? obj)
    {
        if (obj is Car car) return ((Name == car.Name) && (Engine == car.Engine) && (MaxSpeed == car.MaxSpeed));
        return false;
    }
}