bool isWork = true;

while (isWork)
{
    Console.Write("Введите номер задания :");

    int.TryParse(Console.ReadLine(), out int w);
    {
        switch (w)
        {
            case 1:
                {
                    System.Console.WriteLine("Введите размеры двумерного массива");
                    int Ferst = int.Parse(Console.ReadLine());
                    int Second = int.Parse(Console.ReadLine());
                    double[,] array = Array(Ferst, Second);
                    double[,] Array(int Ferst, int Second)
                    {
                        double[,] array = new double[Ferst, Second];
                        Random random = new Random();

                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                array[i, j] = Math.Round(random.NextDouble() + 1, 1);
                            }
                        }
                        return array;
                    }

                    void Print(double[,] array)
                    {
                        Console.WriteLine();
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                Console.Write($"{array[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    Print(array);

                    break;
                }

            case 2:
                {

                    System.Console.WriteLine("Введите размеры двумерного массива: ");
                    int Ferst = int.Parse(Console.ReadLine());
                    int Second = int.Parse(Console.ReadLine());
                    int[,] array = Array(Ferst, Second);
                    int[,] Array(int Ferst, int Second)
                    {
                        System.Console.WriteLine("Введите первый индекс элемнта: ");
                        int a = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Введите второй индекс элемнта: ");
                        int b = int.Parse(Console.ReadLine());
                        int[,] array = new int[Ferst, Second];
                        Random random = new Random();
                        if (a < array.GetLength(0) && b < array.GetLength(1))
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    array[i, j] = random.Next(10);
                                    if (i == a && j == b) System.Console.WriteLine($"Элемент под индексом {a}.{b} есть, это - {array[i, j]}!");

                                }
                            }
                            Console.WriteLine();
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    Console.Write($"{array[i, j]} ");
                                }
                                Console.WriteLine();
                            }
                        }

                        else System.Console.WriteLine("Такого элемента нет");

                        return array;
                    }
                    break;
                }

            case 3:
                {
                    int[,] array = new int[3, 4];
                    Random random = new Random();
                    double a = 0;
                    double b = 0;
                    double c = 0;
                    double d = 0;

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            array[i, j] = random.Next(10);
                            if (j == 0) a = (a + array[i, j]);
                            if (j == 1) b = (b + array[i, j]);
                            if (j == 2) c = (c + array[i, j]);
                            if (j == 3) d = (d + array[i, j]);
                        }
                    }
                    a = a / array.GetLength(0);
                    b = b / array.GetLength(0);
                    c = c / array.GetLength(0);
                    d = d / array.GetLength(0);
                    System.Console.WriteLine($"Первый столбец - средене арифметическое: {Math.Round(a, 2)}");
                    System.Console.WriteLine($"Второй столбец - средене арифметическое: {Math.Round(b, 2)}");
                    System.Console.WriteLine($"Третий столбец - средене арифметическое: {Math.Round(c, 2)}");
                    System.Console.WriteLine($"Четвертый столбец - средене арифметическое: {Math.Round(d, 2)}");

                    void Print(int[,] array)
                    {
                        Console.WriteLine();
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                Console.Write($"{array[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    Print(array);
                    break;
                }

            case -1: isWork = false; break;
        }

    }
}