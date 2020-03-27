using System;

namespace HomeWork26._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int summaPokupki = 0;
            string spisokPokupok = "";
            int k = 0;
            start:
            k++;
            Console.Write("Скидка в 3% если сумма покупки больше 500 сомони или в 5% если сумма больше 1000 сомони.");
            Console.Write("\n"+"Сумма вашей покупки "+summaPokupki);
            Console.Write("\n"+"Существующие товары:"
            +"\n1. Наушники - 150 с"
            +"\n2. Очки - 200 с"
            +"\n3. Скейт - 300 с"
            +"\n4. Рюкзак - 100 с"
            +"\n5. Выход\n");
            System.Console.Write("Нажмите на соответствующий номер чтобы купить или выйти: ");
            string choseNumber = Console.ReadLine();
            switch (choseNumber)
            {
                case "1": {
                    spisokPokupok += (k == 1)?"Наушники":", наушники";
                    summaPokupki += 150;
                    Console.Clear();
                    goto start;
                }
                case "2": {
                    spisokPokupok += (k == 1)?"Очки":", очки";
                    summaPokupki += 200;
                    Console.Clear();
                    goto start;
                }
                case "3": {
                    spisokPokupok += (k == 1)?"Скейт":", скейт";
                    summaPokupki += 300;
                    Console.Clear();
                    goto start;
                }
                case "4": {
                    spisokPokupok += (k == 1)?"Рюкзак":", рюкзак";
                    summaPokupki += 100;
                    Console.Clear();
                    goto start;
                }
                case "5": goto end;
                default: Console.Clear(); goto start;
            }
            end:
            double skidka = (summaPokupki >= 500 && 1000> summaPokupki)? summaPokupki * 3 / 100:(summaPokupki >= 1000)?summaPokupki * 5 / 100:0;
            System.Console.WriteLine($"Вашк список покупок: {spisokPokupok}");
            Console.WriteLine($"Скидка составляет: {skidka} сомони");
            System.Console.Write($"Сумма к оплате: {summaPokupki - skidka} сомони"+" \nБлагодарим что выбрали наш магазин, всего доброго. :)");
            Console.ReadKey();
        }
    }
}
