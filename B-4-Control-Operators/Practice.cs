using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            var today = DateTime.Today;
            var dayOfWeek = (int)today.DayOfWeek;
            switch (dayOfWeek-1)
            {
                case 0:
                    Console.WriteLine("Доброго понедельника, Ольга!");
                    break;
                case 1:
                    Console.WriteLine("Доброго вторника, Ольга!");
                    break;
                case 2:
                    Console.WriteLine("Доброй среды, Ольга!");
                    break;
                case 3:
                    Console.WriteLine("Доброго четверга, Ольга!");
                    break;
                case 4:
                    Console.WriteLine("Доброй пятницы, Ольга!");
                    break;
                case 5:
                    Console.WriteLine("Доброй субботы, Ольга!");
                    break;
                case 6:
                    Console.WriteLine("Доброго воскресенья, Ольга!");
                    break;
            }
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            int X, Y;
            Console.WriteLine("Введите первое число: ");
            X = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            Y = Int32.Parse(Console.ReadLine());
            if(X>Y)
            {
                Console.WriteLine($"Значение X больше Y на {X-Y}");
            }
            else if(Y>X)
            {
                Console.WriteLine($"Значение X меньше Y на {Y - X}");
            }
            else
            {
                Console.WriteLine("Значения равны");
            }
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            int X, Y;
            Console.WriteLine("Введите первое число: ");
            X = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            Y = Int32.Parse(Console.ReadLine());
            if((X>=0)&&(Y>=0))
            {
                if (X > Y)
                {
                    Console.WriteLine($"Значение X больше Y на {X - Y}");
                }
                else if (Y > X)
                {
                    Console.WriteLine($"Значение X меньше Y на {Y - X}");
                }
                else
                {
                    Console.WriteLine("Значения равны");
                }
            }
            else
            {
                Console.WriteLine("X или/и Y меньше 0");
            }
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            int answer;
            Console.WriteLine("Загадайте число");
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine($"Вы загадали {i}?(1-Y/2-N)");
                answer = Int32.Parse(Console.ReadLine());
                if(answer==1)
                {
                    Console.WriteLine("Akinator wins");
                    break;
                }
            }
        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            var today = DateTime.Today;
            var dayOfWeek = (int)today.DayOfWeek;
            switch (dayOfWeek - 1)
            {
                case 0:
                    Console.WriteLine("Доброго понедельника, Ольга!");
                    break;
                case 1:
                    Console.WriteLine("Доброго вторника, Ольга!");
                    break;
                case 2:
                    Console.WriteLine("Доброй среды, Ольга!");
                    break;
                case 3:
                    Console.WriteLine("Доброго четверга, Ольга!");
                    break;
                case 4:
                    Console.WriteLine("Доброй пятницы, Ольга!");
                    break;
                case 5:
                    Console.WriteLine("Доброй субботы, Ольга!");
                    break;
                case 6:
                    Console.WriteLine("Доброго воскресенья, Ольга!");
                    break;
            }
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            Console.WriteLine("Нажмите игровую клавишу: ");

            var button = Console.ReadKey();
            switch (button.KeyChar)
            {
                case 'W':
                case 'w':
                    Console.WriteLine(" Вверх");
                    break;
                case 'S':
                case 's':
                    Console.WriteLine(" Вниз");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine(" Влево");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine(" Вправо");
                    break;
                default:
                    Console.WriteLine(" Неверная клавиша");
                    break;
            }
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            for(int i=1;i<=10;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine($"{i}-чётное");
                }
                else
                {
                    Console.WriteLine($"{i}-нечётное");
                }
            }
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
            for (int i = 30; i >= 0; i--)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}-делится без остатка на 3");
                }
                else
                {
                    Console.WriteLine($"{i}-не делится без остатка на 3");
                }
            }
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
            const int N = 10;
            int[,] array = new int[N, N];
            Random ran = new Random();
            for(int i=0;i<N;i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = ran.Next(-10, 10);
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
            for(int i=0;i<6;i++)
            {
                Console.WriteLine("Привет, мир!");
            }
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            int i = 10,j=1;
            do
            {
                Console.WriteLine($"{i} негритят отправились обедать,");
                i--;
                Console.WriteLine($"{j} поперхнулся, их осталось {i}.");

                Console.WriteLine($"{i} негритят, поев, клевали носом,");
                i--;
                Console.WriteLine($"{j} не смог проснуться, их осталось {i}.");

                Console.WriteLine($"{i} негритят в Девон ушли потом,");
                i--;
                Console.WriteLine($"{j} не возвратился, остались {i}.");

                Console.WriteLine($"{i} негритят дрова рубили вместе,");
                i--;
                Console.WriteLine($"Зарубил {j} себя - и осталось {i} их.");

                Console.WriteLine($"{i} негритят пошли на пасеку гулять,");
                i--;
                Console.WriteLine($"{j} ужалил шмель, их осталось {i}.");

                Console.WriteLine($"{i} негритят судейство учинили,");
                i--;
                Console.WriteLine($"Засудили {j}, осталось их {i}.");

                Console.WriteLine($"{i} негритенка пошли купаться в море,");
                i--;
                Console.WriteLine($"{j} попался на приманку, их осталось {i}.");

                Console.WriteLine($"{i} негритят в зверинце оказались,");
                i--;
                Console.WriteLine($"{j} схватил медведь, и {i} остались.");

                Console.WriteLine($"{i} негритят легли на солнцепеке,");
                i--;
                Console.WriteLine($"{i} сгорел - и вот {i}, несчастный, одинокий.");

                Console.WriteLine("Последний негритенок поглядел устало,");
                i--;
                Console.WriteLine("Он пошел повесился, и никого не стало");
            } while (i >= 1);
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
            for (int i = 0; i >= -10; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}-чётное");
                }
                else
                {
                    Console.WriteLine($"{i}-нечётное");
                }
            }
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            int amount=0;
            string word;
            Console.WriteLine("Введите слово на английском: ");
            word = Console.ReadLine();
            for(int i=0;i<word.Length;i++)
            {
                if((int)word[i]==97)
                {
                    amount++;
                }
            }
            Console.WriteLine($"Количество букв 'a': {amount}");
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            for(int i=90;i>=65;i--)
            {
                Console.WriteLine(((char)i));
            }
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            int n,i=1;
            Console.WriteLine("Введите диапазон: ");
            n = Int32.Parse(Console.ReadLine());
            while (i <= n)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
            int n, i = 1;
            Console.WriteLine("Введите диапазон: ");
            n = Int32.Parse(Console.ReadLine());
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= n);
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
            int i = 6;
            while(i>=1)
            {
                Console.WriteLine("Привет, мир!");
                i--;
            }
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            int osnovanie,pokazatel_stepeni,rez=1;
            Console.WriteLine("Введите основание: ");
            osnovanie = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите показатель степени: ");
            pokazatel_stepeni = Int32.Parse(Console.ReadLine());
            while(pokazatel_stepeni!=0)
            {
                rez *= osnovanie;
                pokazatel_stepeni--;
            }
            Console.WriteLine($"Результат: {rez}");
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            int user_rez=0;
            while (user_rez != 4)
            {
                Console.WriteLine("Решите уравнение 2+2= ");
                user_rez = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Решение правильное");
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            int number_of_player1,player1_sum=0;
            while(player1_sum<25)
            {
                Console.WriteLine("Введите число от 1 до 6:");
                number_of_player1 = Int32.Parse(Console.ReadLine());
                if((number_of_player1>6)||(number_of_player1<1))
                {
                    continue;
                }
                player1_sum += number_of_player1;
                Console.WriteLine($"Сумма ходов игрока1: {player1_sum}");
            }
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
            int number_of_player1, number_of_player2, player1_sum = 0, player2_sum = 0;
            while ((player1_sum < 25)||(player2_sum<25))
            {
                Console.WriteLine("Введите число от 1 до 6:");
                number_of_player1 = Int32.Parse(Console.ReadLine());
                number_of_player2 = Int32.Parse(Console.ReadLine());
                if (((number_of_player1 > 6) || (number_of_player1 < 1))||((number_of_player2 > 6)||(number_of_player2 < 1)))
                {
                    continue;
                }
                player1_sum += number_of_player1;
                player2_sum += number_of_player2;
                Console.WriteLine($"Сумма ходов игрока1: {player1_sum}");
                Console.WriteLine($"Сумма ходов игрока2: {player2_sum}");
            }
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            int number1,number2,operation,result;
            Console.WriteLine("Введите первое число: ");
            number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            number2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию(1-сложение; 2-вычитание; 3-умножение; 4-деление): ");
            operation = Int32.Parse(Console.ReadLine());
            if (operation==1)
            {
                result = number1 + number2;
            }
            else if(operation==2)
            {
                result = number1 - number2;
            }
            else if(operation==3)
            {
                result = number1 * number2;
            }
            else if(operation==4)
            {
                result = number1 / number2;
            }
            else
            {
                Console.WriteLine("Неверное значение");
                return;
            }
            Console.WriteLine($"Результат: {result}");
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            int number1, number2, operation, result = 0;
            Console.WriteLine("Введите первое число: ");
            number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            number2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию(1-сложение; 2-вычитание; 3-умножение; 4-деление): ");
            operation = Int32.Parse(Console.ReadLine());
            switch(operation)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Неверное значение");
                    break;
            }
            Console.WriteLine($"Результат: {result}");
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            string word, word_reverse="";
            Console.WriteLine("Введите слово: ");
            word = Console.ReadLine();
            for(int j=word.Length - 1;j >= 0;j--)
            {
                word_reverse += word[j];
            }
            Console.WriteLine(word_reverse);
        }
    }
}
