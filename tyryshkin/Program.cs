using System;

namespace homework_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("№1");

            Console.WriteLine("Тип данных – Максимальное значение – Минимальное значение");
            Console.WriteLine("int    – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("long   – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("float  – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("double – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("decimal – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("byte   – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("sbyte  – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("short  – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("ushort – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("char   – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("bool   – Max: {1} – Min: {0}", uint.MaxValue, uint.MinValue);

            Console.WriteLine("№2");

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите название вашего города: ");
            string city = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш PIN-код: ");
            string pinCode = Console.ReadLine();
            Console.WriteLine("\nВведенная информация:");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"PIN-код: {pinCode}");

            Console.WriteLine("№3");

            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string convertedString = "";


            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    convertedString += char.ToUpper(c);
                }
                else if (char.IsUpper(c))
                {
                    convertedString += char.ToLower(c);
                }
                else
                {
                    convertedString += c;
                }
            }

            Console.WriteLine("Преобразованная строка: " + convertedString);

            Console.WriteLine("№4");

            Console.Write("Введите строку: ");
            string mainString = Console.ReadLine();

            Console.Write("Введите подстроку для поиска: ");
            string subString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(mainString) || string.IsNullOrWhiteSpace(subString))
            {
                Console.WriteLine("Обе строки должны быть непустыми.");
                return;
            }

            int count = 0;
            int startIndex = 0;

            while ((startIndex = mainString.IndexOf(subString, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                startIndex += subString.Length;
            }

            Console.WriteLine($"Количество вхождений подстроки \"{subString}\" в строке: {count}");

            Console.WriteLine("№5");

            Console.Write("Введите стандартную цену (normPrice): ");
            int normPrice = int.Parse(Console.ReadLine());

            Console.Write("Введите скидку в дьюти фри (salePrice в %): ");
            int salePrice = int.Parse(Console.ReadLine());

            Console.Write("Введите стоимость отпуска (holidayPrice): ");
            int holidayPrice = int.Parse(Console.ReadLine());

            double discountAmount = normPrice * (salePrice / 100.0);

            int bottlesNeeded = (int)(holidayPrice / discountAmount);

            Console.WriteLine($"Количество бутылок виски, которые необходимо купить: {bottlesNeeded}");
        }
    }
}