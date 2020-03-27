using System;

namespace HomeWork26._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Задание 2
            // int summaPokupki = 0;
            // string spisokPokupok = "";
            // int k = 0;
            // start:
            // k++;
            // Console.Write("Скидка в 3% если сумма покупки больше 500 сомони или в 5% если сумма больше 1000 сомони.");
            // Console.Write("\n"+"Сумма вашей покупки "+summaPokupki);
            // Console.Write("\n"+"Существующие товары:"
            // +"\n1. Наушники - 150 с"
            // +"\n2. Очки - 200 с"
            // +"\n3. Скейт - 300 с"
            // +"\n4. Рюкзак - 100 с"
            // +"\n5. Выход\n");
            // System.Console.Write("Нажмите на соответствующий номер чтобы купить или выйти: ");
            // string choseNumber = Console.ReadLine();
            // switch (choseNumber)
            // {
            //     case "1": {
            //         spisokPokupok += (k == 1)?"Наушники":", наушники";
            //         summaPokupki += 150;
            //         Console.Clear();
            //         goto start;
            //     }
            //     case "2": {
            //         spisokPokupok += (k == 1)?"Очки":", очки";
            //         summaPokupki += 200;
            //         Console.Clear();
            //         goto start;
            //     }
            //     case "3": {
            //         spisokPokupok += (k == 1)?"Скейт":", скейт";
            //         summaPokupki += 300;
            //         Console.Clear();
            //         goto start;
            //     }
            //     case "4": {
            //         spisokPokupok += (k == 1)?"Рюкзак":", рюкзак";
            //         summaPokupki += 100;
            //         Console.Clear();
            //         goto start;
            //     }
            //     case "5": goto end;
            //     default: Console.Clear(); goto start;
            // }
            // end:
            // double skidka = (summaPokupki >= 500 && 1000> summaPokupki)? summaPokupki * 3 / 100:(summaPokupki >= 1000)?summaPokupki * 5 / 100:0;
            // System.Console.WriteLine($"Вашк список покупок: {spisokPokupok}");
            // Console.WriteLine($"Скидка составляет: {skidka} сомони");
            // System.Console.Write($"Сумма к оплате: {summaPokupki - skidka} сомони"+" \nБлагодарим что выбрали наш магазин, всего доброго. :)");
            //Задание 3
            System.Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            System.Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            System.Console.Write("Введите третье число: ");
            double c = double.Parse(Console.ReadLine());
            System.Console.Write("Введите четвертое число: ");
            double d = double.Parse(Console.ReadLine());
            double min_ = a;
            min_ = (a > b)?((b > c)?( (c > d)?d:c):(b > d)?d:b):((a > c)?( (c > d)?d:c):(a > d)?d:a);
            if((a == b) && (c == d))
            {
                System.Console.WriteLine($"{a*b*c*d}");
            }
            else if (!(a < b && b < c && c < d))
            {
                System.Console.WriteLine("Минимальным из введенных чисел является "+min_);
                System.Console.WriteLine($"Минимальным из введенных чисел является {Math.Min(Math.Min(a,b),Math.Min(c,d))}");
            }
            else {
                System.Console.WriteLine("Числа расположены по возрастанию");
            }
            Console.ReadKey();
        }
    }
}
