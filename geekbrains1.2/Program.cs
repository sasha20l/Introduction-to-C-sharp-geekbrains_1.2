using System;


namespace geekbrains1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int averageTemperature = -1;

            while (true)
            {
                string action = Action();

                switch (action)
                {
                    case "1":
                        averageTemperature = AverageTemperature();
                        break;
                    case "2":
                        MonthName(averageTemperature);
                        break;
                    case "3":
                        ParityOfNumbers();
                        break;
                }
            }
        }

        private static string Action()
        {
            string action;
            while (true)
            {
                Console.WriteLine("Выберите пункт меню :\r\n1 - Среднесуточная t.\r\n2 - Название месяца.\r\n3 - Четное или не четное число.\r\n0 - Выход.\r\n");

                action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        Console.WriteLine("Вы выбрали среднесуточную t.\r\n");
                        return action;
                    case "2":
                        Console.WriteLine("Вы выбрали название месяца.\r\n");
                        return action;
                    case "3":
                        Console.WriteLine("Вы выбрали четное или не четное число.\r\n");
                        return action;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Вы нажали не верный символ");
                        break;
                }
            }
        }

        private static int AverageTemperature()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите максимальную t за сутки");
                    int tMax = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите минимальную t за сутки");
                    int tMin = Int32.Parse(Console.ReadLine());
                    int averageTemperature = (tMax + tMin) / 2;
                    Console.WriteLine($"Среднесуточная температура - {averageTemperature}");
                    return averageTemperature;
                }
                catch
                {
                    Console.WriteLine("Введите числовое значение!\r\n");
                }
            }
            

        }
        private static void MonthName(int averageTemperature)
        {
            int temperature = averageTemperature;
            while (true)
            {

                    Console.WriteLine("Введите порядковый номер месяца 1-12 или 0 для выхода");
                    string month = Console.ReadLine();

                    switch (month)
                    {
                    case "0":
                        return;
                    case "1":
                            Console.WriteLine("Январь.\r\n");
                            if (temperature == 0) Console.WriteLine("Дождливая зима\r\n");
                            break;
                        case "2":
                            Console.WriteLine("Февраль.\r\n");
                            if (temperature == 0) Console.WriteLine("Дождливая зима\r\n");
                            break;
                        case "3":
                            Console.WriteLine("Март.\r\n");
                            break;
                        case "4":
                            Console.WriteLine("Апрель.\r\n");
                            break;
                        case "5":
                            Console.WriteLine("Май.\r\n");
                            break;
                        case "6":
                            Console.WriteLine("Июнь.\r\n");
                            break;
                        case "7":
                            Console.WriteLine("Июль.\r\n");
                            break;
                        case "8":
                            Console.WriteLine("Август.\r\n");
                            break;
                        case "9":
                            Console.WriteLine("Сентябрь.\r\n");
                            break;
                        case "10":
                            Console.WriteLine("Октябрь.\r\n");
                            break;
                        case "11":
                            Console.WriteLine("Ноябрь.\r\n");
                            break;
                        case "12":
                            Console.WriteLine("Декабрь.\r\n");
                            if (temperature == 0) Console.WriteLine("Дождливая зима\r\n");
                            break;
                        default:
                            Console.WriteLine("Вы нажали не верный символ");
                            break;
                    }
            }

        }
        private static void ParityOfNumbers()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите число для проверки");
                    int firstNumber = Int32.Parse(Console.ReadLine());
                    string parityOfNumbers = firstNumber % 2 == 0 ? "Число четное.\r\n" : "Число не четное.\r\n";
                    Console.WriteLine(parityOfNumbers);
                    return;
                }
                catch
                {
                    Console.WriteLine("Введите числовое значение!\r\n");
                }
            }
        }
    }
}
