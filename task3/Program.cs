//using System.Net.NetworkInformation;
//using System.Runtime.InteropServices.Marshalling;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите курс Рубля к Доллару");
            double RubDol = Convert.ToDouble(Console.ReadLine());
            //double RubDol = 83.59;
            Console.WriteLine("\nВведите курс Евро к Доллару");
            double EurDol = Convert.ToDouble(Console.ReadLine());
            //double EurDol = 0.8514;
            Console.WriteLine("\n");

            Conv conv = new Conv(RubDol, EurDol);

            //Доллары и его Конвертация в другие валюты
            CurrencyUSD usd1 = new CurrencyUSD(100);
            CurrencyRUB rub1 = (CurrencyRUB)usd1;
            CurrencyEUR eur1 = (CurrencyEUR)usd1;
            Console.WriteLine($"Доллары: {usd1.Value}; Конвертирвоано в Рубли: {string.Format("{0:f2}", rub1.Value)}; Конвертирвоано в Евро {string.Format("{0:f2}", eur1.Value)}\n\n");

            //Евро и его Конвертация в другие валюты
            CurrencyEUR eur2 = new CurrencyEUR(100.0);
            CurrencyUSD usd2 = (CurrencyUSD)eur2;
            CurrencyRUB rub2 = (CurrencyRUB)eur2;
            Console.WriteLine($"Евро: {eur2.Value}; Конвертирвоано в Рубли: {string.Format("{0:f2}", rub2.Value)}; Конвертирвоано в Доллары {string.Format("{0:f2}", usd2.Value)}\n\n");

            //Рубли и его Конвертация в другие валюты
            CurrencyRUB rub3 = new CurrencyRUB(10000.0);
            CurrencyUSD usd3 = (CurrencyUSD)rub3;
            CurrencyEUR eur3 = (CurrencyEUR)rub3;
            Console.WriteLine($"Рубли: {rub3.Value}; Конвертирвоано в Доллары: {string.Format("{0:f2}", usd2.Value)}, Конвертирвоано в Евро {string.Format("{0:f2}", eur3.Value)}\n\n");
        }   
    }
}
class Conv //Класс для хранения значений концертации валют
{
    public static double _RubDol;
    public static double _EurDol;

    public Conv(double RubDol, double EurDol)
    {
        _RubDol = RubDol;
        _EurDol = EurDol;
    }
}
class Currency
{
    public double Value { get; set; }
    public Currency(double value)
    {
        Value = value;
    }
}

class CurrencyUSD : Currency
{
    public CurrencyUSD(double value) : base(value){ }

    public static explicit operator CurrencyRUB(CurrencyUSD ob) { return new CurrencyRUB(ob.Value * Conv._RubDol); }

    public static explicit operator CurrencyEUR(CurrencyUSD ob) { return new CurrencyEUR(ob.Value * Conv._EurDol); }
}

class CurrencyEUR : Currency
{
    public CurrencyEUR(double value) : base(value) { }

    public static explicit operator CurrencyRUB(CurrencyEUR ob) { return new CurrencyRUB(ob.Value / Conv._EurDol * Conv._RubDol); }

    public static explicit operator CurrencyUSD(CurrencyEUR ob) { return new CurrencyUSD(ob.Value / Conv._EurDol); }
}

class CurrencyRUB : Currency
{
    public CurrencyRUB(double value) : base(value) { }

    public static explicit operator CurrencyEUR(CurrencyRUB ob) { return new CurrencyEUR(ob.Value / Conv._RubDol * Conv._EurDol); }

    public static explicit operator CurrencyUSD(CurrencyRUB ob) { return new CurrencyUSD(ob.Value / Conv._RubDol); }
}