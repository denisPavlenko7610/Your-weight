using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_weight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес (кг): ");
            float weight;
            var weightResult = float.TryParse(Console.ReadLine(), out weight);

            if (!weightResult)
            {
                Console.WriteLine("Данные веса введены неверно.Укажите вес в (кг). Используйте разделение ',' ");
            }
            else
            {
                Console.WriteLine("Введите рост (в метрах): ");
                float height;
                var heightResult = float.TryParse(Console.ReadLine(), out height);

                if (!heightResult)
                {
                    Console.WriteLine("Данные роста введены неверно. Введите рост в метрах. Используйте для разделение ',' ");
                }
                else
                {
                    var index = weight / (height * height);

                    if (index < 18.5)
                    {
                        Console.WriteLine("Индекс массы тела = {0} - Анорексия", index);
                    }
                    else if (index >= 18.5 && index < 25)
                    {
                        Console.WriteLine("Индекс массы тела = {0} - Нормальная масса тела", index);
                    }
                    else if (index >= 25 && index < 30)
                    {
                        Console.WriteLine("Индекс массы тела = {0} Превышение нормы, угроза ожирения", index);
                    }
                    else if (index >= 30 && index < 35)
                    {
                        Console.WriteLine("Индекс массы тела = {0} - Ожирение 1-й степени", index);
                    }
                    else if (index >= 35 && index < 40)
                    {
                        Console.WriteLine("Индекс массы тела = {0} - Ожирение 2 - й степени", index);
                    }
                    else if (index >= 40)
                    {
                        Console.WriteLine("Индекс массы тела = {0} - Ожирение 3-й степени", index);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверные данные. Пожалуйста, повторите ввод...");
                    }
                }
            }
            Console.ReadLine();
        }


    }
}

