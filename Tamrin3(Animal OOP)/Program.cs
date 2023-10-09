using System.Threading.Channels;
using System.Xml.Linq;
using Tamrin3_Animal_OOP_;

internal class Program
{
    private static void Main(string[] args)
    {
        Cat cat1 = new Cat("jessy", 15, "male");
        Swimable("jessy", true);
        Walkable("jessy", true);
        showinformation("jessy", 14, "female");
        showinformation(false);
        Console.ReadKey();

    }
    static void Swimable(string name, bool SYesorNO)
    {
        if (SYesorNO == true)
        {
            Console.WriteLine(name + "is swimable");
        }
        else
        {
            Console.WriteLine(name + "is not swimable!!!");
        }

    }

    static void Walkable(string name, bool WYesorNO)
    {
        if (WYesorNO == true)
        {
            Console.WriteLine(name + "can walk");
        }
        else
        {
            Console.WriteLine(name + "can not walk");
        }
    }
    static void showinformation(string Iname, int Iage, string IMale_or_Female)
    {
        Console.WriteLine("name : " + Iname, "age :" + Iage + "sex : " + IMale_or_Female);
    }

    static void showinformation(bool marriedornot)
    {
        if (marriedornot)
        {
            Console.WriteLine("congratulate");
        }
        else
        {
            Console.WriteLine("lest try for it");
        }

    }
}