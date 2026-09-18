//Задание 1

//Console.WriteLine("Введите длину прямоугольника:");
//int length = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите ширину прямоугольника:");
//int width = Convert.ToInt32(Console.ReadLine());
//int area = length * width;
//int perimeter = 2 * (length + width);
//Console.WriteLine($"Площадь: {area}");
//Console.WriteLine($"Периметр: {perimeter}");

//Задание 2

//Console.WriteLine("Введиет валюту: ");
//double rubl = Convert.ToDouble(Console.ReadLine());
//double dol = rubl / 84.2;
//Console.WriteLine($"Доллары: {dol}");

//Задание 3

//double sum = 0;
//for(int i = 0; i < 7; i++)
//{
//    double a = Convert.ToDouble(Console.ReadLine());
//    sum += a;
//}
//double avg = sum / 7;
//Console.WriteLine($"Средняя температура за неделю: {avg}");

//Задание 4

//Console.WriteLine("Оценки студента 1");
//int s1 = 0;
//for (int i = 0; i < 5; i++)
//{
//    int t = Convert.ToInt32(Console.ReadLine());
//    s1 += t;
//}
//Console.WriteLine("Оценки студента 2");
//int s2 = 0;
//for (int i = 0; i < 5; i++)
//{
//    int t = Convert.ToInt32(Console.ReadLine());
//    s2 += t;
//}
//Console.WriteLine("Оценки студента 3");
//int s3 = 0;
//for (int i = 0; i < 5; i++)
//{
//    int t = Convert.ToInt32(Console.ReadLine());
//    s3 += t;
//}
//double av1 = s1 / 5;
//double av2 = s2 / 5;
//double av3 = s3 / 5;
//Console.WriteLine($"Среднее студента 1: {av1}, Среднее студента 2: {av2}, Среднее студента 3: {av3}");

//Задание 5

//int[,] matrix = new int[3, 3];
//int[,] new_matrix = new int[3, 3];
//string input = Console.ReadLine();
//string[] numbers = input.Split(' ');

//int a = 0;
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        matrix[i, j] = Convert.ToInt32(numbers[a]);
//        a++;
//    }
//}
//for(int i = 0; i < 3; i++)
//{
//    for (int j = 0;j < 3; j++)
//    {
//        new_matrix[j, i] = matrix[i, j];
//    }
//}

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(new_matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}
