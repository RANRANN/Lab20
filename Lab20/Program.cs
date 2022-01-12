using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {
        delegate double MyDelegate();
        delegate double MyDelegate2(double r);

        static void Main(string[] args)
        {
            MyDelegate myDelegate1 = GetLength;
            if (myDelegate1 != null)
            {
                double L = myDelegate1();
                Console.WriteLine(L);
            }
            Console.WriteLine();

            MyDelegate myDelegate2 = new MyDelegate(GetArea);
            Console.WriteLine(myDelegate2?.Invoke());
            Console.WriteLine();

            MyDelegate2 myDelegate3 = GetVolume;
            Console.WriteLine($"Объём шара радиусом 5 единиц = { myDelegate3?.Invoke(5)}");
            Console.ReadKey();
        }
        static double GetLength()
        {
            Console.Write("Введите радиус круга ");
            double r = Convert.ToDouble(Console.ReadLine());
            return 2 * Math.PI * r;
        }
        static double GetArea()
        {
            Console.Write("Введите радиус круга ");
            double r = Convert.ToDouble(Console.ReadLine());
            return Math.PI * Math.Pow(r, 2);
        }
        static double GetVolume(double r) => 4 / 3 * Math.PI * Math.Pow(r, 3);
    }
}
