using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_ex4_Smolovyk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smolovyk Daniil");
            Console.Write("Введіть кількість комп'ютерів у класі №1 (C1): ");
            int class1 = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість комп'ютерів у класі №2 (C2): ");
            int class2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВересень:");
            Console.WriteLine($"Клас №1: {class1}, Клас №2: {class2}");
            int temp = class1;
            class1 = class2; 
            class2 = temp;
            Console.WriteLine("\nЖовтень (після переміщення):");
            Console.WriteLine($"Клас №1: {class1}, Клас №2: {class2}");
            class1 += 4;
            class2 -= 1;
            Console.WriteLine("\nГрудень (після оновлення):");
            Console.WriteLine($"Клас №1: {class1}, Клас №2: {class2}");
        }
    }
}
