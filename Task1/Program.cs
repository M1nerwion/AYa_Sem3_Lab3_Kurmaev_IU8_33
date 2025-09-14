namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

struct Vector
{
    double x, y, z;

    public static Vector operator +(Vector a, Vector b)//Сложение двух векторов
    {
        return new Vector { x = a.x + b.x, y = a.y + b.y, z = a.z + b.z };
    }

    public static Vector operator *(Vector a, Vector b)//Умножение Вектор на вектор
    {
        return new Vector { x = a.x * b.x, y = a.y * b.y, z = a.z * b.z };
    }

    public static Vector operator *(Vector a, int b)//Умножение Вектор на число
    {
        return new Vector { x = a.x * b, y = a.y * b, z = a.z * b };
    }
    public static Vector operator *(int b, Vector a)//Умножение Вектор на число, но в другой последовательности операндов
    {
        return new Vector { x = a.x * b, y = a.y * b, z = a.z * b };
    }

    public static bool operator >(Vector a, Vector b)//Больше
    {
        return (Math.Pow(a.x, 2) + Math.Pow(a.y, 2) + Math.Pow(a.z, 2)) > (Math.Pow(b.x, 2) + Math.Pow(b.y, 2) + Math.Pow(b.z, 2));//Без квадратного корня, так как достаточно сравнить подкоренные выражения
    }

    public static bool operator <(Vector a, Vector b)//Меньше
    {
        return (Math.Pow(a.x, 2) + Math.Pow(a.y, 2) + Math.Pow(a.z, 2)) < (Math.Pow(b.x, 2) + Math.Pow(b.y, 2) + Math.Pow(b.z, 2));//Без квадратного корня, так как достаточно сравнить подкоренные выражения
    }
}
