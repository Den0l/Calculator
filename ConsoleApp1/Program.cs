using System;

string txt;

do
{
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычетание");
    Console.WriteLine("3. Перемножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возведение числа в степень");
    Console.WriteLine("6. Квадратный корень");
    Console.WriteLine("7. 1 Процент");
    Console.WriteLine("8. Факториал");
    Console.WriteLine("9. Выход");
    txt = Console.ReadLine();

    if(txt == "1")
    {
        Console.Write("Введите первое число: ");
      double  a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Второе число: ");
      double  b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Результат:" + (a + b));

    }
    else if(txt == "2")
    {
        Console.Write("Введите первое число: ");
        double  a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Второе число: ");
       double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Результат:" + (a - b));
    }
    else if (txt == "3")
    {
        Console.Write("Введите первое число: ");
       double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Второе число: ");
      double  b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Результат:" + (a * b));
    }
    else if (txt == "4")
    {
        Console.Write("Введите первое число: ");
      double  a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Второе число: ");
      double  b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Результат:" + (a / b));
    }
    else if (txt == "5")
    {
        Console.Write("Введите первое число: ");
      double  a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Степень: ");
       double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Результат:" + Math.Pow(a, b));
    }
    else if (txt == "6")
    {
        Console.Write("Введите число: ");
     double   a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Результат:" + Math.Sqrt(a));
    }
    else if (txt == "7")
    {
        Console.Write("Введите число: ");
      double  a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Результат" + (a/100));
        
    }
    else if (txt == "8")
    {
        int b = 1;
        Console.Write("Введите число: ");
       double a = Convert.ToDouble(Console.ReadLine());
        for(int i = 1; i <= a; i++)
        {
            b = i * b;
        }
        Console.WriteLine("Результат: " + b);
    }
    else if(txt == "9")
    {

    }
    else
    {
        Console.WriteLine("Такой команды нет");
    }
} while (txt != "9");