namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int action = 0;

            do
            {
                Console.WriteLine("Выберите действие\n" +
                    "1. Сложение\n" +
                    "2. Вычитание\n" +
                    "3. Умножение\n" +
                    "4. Деление\n" +
                    "5. Возвести в степень\n" +
                    "6. Найти квадратный корень из числа\n" +
                    "7. Найти факториал\n" +
                    "8. Найти 1% от числа\n" +
                    "9. Выход из программы");
                action = Convert.ToInt32(Console.ReadLine());

                if (action < 4)
                {
                    Console.WriteLine("Введите первое число");
                    double Num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double Num2 = Convert.ToDouble(Console.ReadLine());

                    switch (action)
                    {
                        case 1:
                            Console.WriteLine($"Сумма числа {Num1} и {Num2}\n" +
                                $"Результат: {Num1 + Num2}\n");
                            break;
                        case 2:
                            Console.WriteLine($"Разность чисел {Num1} и {Num2}\n" +
                                $"Результат: {Num1 - Num2}\n");
                            break;
                        case 3:
                            Console.WriteLine($"Произведение чисел {Num1} и {Num2}\n" +
                                $"Результат: {Num1 * Num2}\n");
                            break;
                        case 4:
                            Console.WriteLine($"Частность чисел {Num1} и {Num2}\n" +
                                $"Результат: {Num1 / Num2}\n");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                }
                else if (action == 5)
                {
                    Console.WriteLine("Введите число");
                    double Num = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень");
                    double Degree = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{Num} в степени {Degree} = {Math.Pow(Num, Degree)}\n");
                }
                else if (action > 5 && action < 9)
                {
                    Console.WriteLine("Введите число");
                    double Num = Convert.ToDouble(Console.ReadLine());
                    switch (action)
                    {
                        case 6:
                            Console.WriteLine($"Квадратный корень из числа {Num} = {Math.Sqrt(Num)}\n");
                            break;
                        case 7:
                            double Factorial = 1;

                            for (int i = 2; i <= Num; i++)
                            {
                                Factorial *= i;
                            }

                            Console.WriteLine($"Факториал числа {Num} = {Factorial}\n");
                            break;
                        case 8:
                            Console.WriteLine($"1% от числа {Num} = {Num / 100}\n");
                            break;
                    }
                }
                else if (action == 9)
                {
                    Console.WriteLine("Выход выполнен.");
                }
            } while (action != 9);
        }
    }
}