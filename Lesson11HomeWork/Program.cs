using Lesson11HomeWork.Task_1;
using Lesson11HomeWork.Task_2;

namespace Lesson11HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------- Task 1 ------------------------------------------------
            var arrayInt = new GenericArrayClass<int>();

            arrayInt.Add(1);
            arrayInt.Add(12);
            arrayInt.Add(11);
            arrayInt.Add(14);
            arrayInt.Add(4);
            arrayInt.Add(54);
            arrayInt.Add(43);
            arrayInt.Add(76);
            arrayInt.Add(3);
            arrayInt.Add(45);   
            Console.WriteLine($"count = {arrayInt.ReturnCount()}");
            arrayInt.Add(117764);
            Console.WriteLine($"count = {arrayInt.ReturnCount()}");
            arrayInt.Add(46);

            Console.WriteLine(arrayInt.GetElement(5));

            //------

            var arrayStr = new GenericArrayClass<string>();

            arrayStr.Add("q");
            arrayStr.Add("qw");
            arrayStr.Add("qwerty");
            arrayStr.Add("qwe");
            arrayStr.Add("qwerty");
            arrayStr.Add("qwerty");
            arrayStr.Add("qwerty");
            arrayStr.Add("qwey");
            arrayStr.Add("qrty");
            arrayStr.Add("qwty");   
            Console.WriteLine($"count = {arrayStr.ReturnCount()}");
            arrayStr.Add("ty");
            Console.WriteLine($"count = {arrayStr.ReturnCount()}");
            arrayStr.Add("y");

            Console.WriteLine(arrayStr.GetElement(2));

            // ------------- Task 2 ------------------------------------------------
            Console.WriteLine("---------------------");

            var finedMax1 = new GenericClass<int>();
            Console.WriteLine($"Макс = {finedMax1.ReturnMax(1, 8, 3)}");

            var finedMax2 = new GenericClass<string>();
            Console.WriteLine($"Макс = {finedMax2.ReturnMax("qwe", "", "qwerty")}");

        }
    }
}