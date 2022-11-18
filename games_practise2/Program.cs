Console.WriteLine("1. Угадай число\n2. Таблица умножения\n3. Вывод делителей числа\n4. Выход из меню");
int select = Convert.ToInt16(Console.ReadLine());
switch (select)
{
    case 1:
        Console.WriteLine("Игра 'Угадай число!'");
        Random random = new Random();
        int input = 0;
        int chislo = random.Next(1, 100);
        Console.WriteLine("Число сгенерированно, попробуйте угадать!");
        while (input != chislo)
        {
            input = Convert.ToInt16(Console.ReadLine());
            if (input > chislo)
                Console.WriteLine("Попробуйте число поменьше!");
            else if (input < chislo)
                Console.WriteLine("Попробуйте число побольше!");
            else Console.WriteLine($"Поздравляем! Вы отгадали число {chislo}!");
        }
        break;

    case 2:
        Console.WriteLine("Таблица умножения");
        /*
        По сути, заполнение матрицы массивов можно оформить при помощи некоторого модификатора
        То есть, при переходе от одной линии к другой он будет повышаться на один и давать нужный результат
        для определенной строки (на первой строке - 1, на второй - 2, на третьей - 3 и т.д.)
        */
        int[,] tab = new int[9,9]; //[1,2] - 1 - это количество строк, 2 - это количество столбцов
        int koeff = 0;
        int znach = 0;
        for (int i = 0; i < tab.GetLength(0); i++) //Цикл входит в строку #i
        {
            znach = 0; //Обнуление значения в ячейке после окончания строки
            koeff++; //Добавление модификатора для вывода строки таблицы
            for (int m = 0; m < tab.GetLength(1); m++) //Цикл входит в столбец #m
            {
                znach = znach + koeff;
                tab[i,m] = znach;
                Console.Write(tab[i,m] + "\t"); 
            }
            Console.WriteLine();
        }
        break;

    case 3:
        Console.WriteLine("Вывод делителей числа:");
        Console.WriteLine("Введите число для обработки:");
        string keyword = "";
        double del = 0;
        double output = 0;
        double check = 0;
        while (keyword != "выход") //Как сделать, чтобы программа не завершалась после ввода одного значения?
        {
            double vvod = Convert.ToDouble(Console.ReadLine());
            while (del != vvod)
            {
                del++;
                output = vvod / del;
                check = vvod % del;
                if (check == 0)
                    Console.Write(del + "\t");
            }
            keyword = Console.ReadLine();
        }
        break;

    default:
        break;

}
