namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vec1 = new Vector(1, 1, 0);
            Vector vec2 = new Vector(-1, 1, 0);
            Vector vec3 = new Vector(-10, -5.5, 3.26);

            Console.WriteLine(vec1+vec2); // 0 2 0
            Console.WriteLine(vec1*5);//5 5 0
            Console.WriteLine(vec1*vec2); //0 так как перпендиклярные вектора
            Console.WriteLine(vec1 > vec3);//False
            Console.WriteLine(vec2 < vec3);//True
            Console.WriteLine(vec1 == vec3);//False
        }
    }
}

struct Vector
{
    double x, y, z;

    public Vector(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static Vector operator +(Vector a, Vector b)//Сложение двух векторов
    {
        return new Vector { x = a.x + b.x, y = a.y + b.y, z = a.z + b.z };
    }

    //public static Vector operator *(Vector a, Vector b)//Умножение Вектор на вектор
    //{
    //    return new Vector { x = a.x * b.x, y = a.y * b.y, z = a.z * b.z };
    //}

    public static double operator *(Vector a, Vector b)//Скалярное Умножение Вектор на вектор
    {
        return a.x*b.x + a.y*b.y + a.z*b.z;
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
    public static bool operator ==(Vector a, Vector b)//Меньше
    {
        return (Math.Pow(a.x, 2) + Math.Pow(a.y, 2) + Math.Pow(a.z, 2)) == (Math.Pow(b.x, 2) + Math.Pow(b.y, 2) + Math.Pow(b.z, 2));//Без квадратного корня, так как достаточно сравнить подкоренные выражения
    }

    public static bool operator !=(Vector a, Vector b)//Меньше
    {
        return (Math.Pow(a.x, 2) + Math.Pow(a.y, 2) + Math.Pow(a.z, 2)) != (Math.Pow(b.x, 2) + Math.Pow(b.y, 2) + Math.Pow(b.z, 2));//Без квадратного корня, так как достаточно сравнить подкоренные выражения
    }

    public override string ToString()//Для вывода в консоль
    {
        return $"{x}, {y}, {z}";
    }
}
