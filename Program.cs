//Задание 1 

// int N = Convert.ToInt32(Console.ReadLine());
// int[] massive = new int[N];
// double sum = 0;
// for (int i = 0; i < N; i++)
// {
//     massive[i] = Convert.ToInt32(Console.ReadLine());
//     sum += massive[i];
// }
// double avg = sum / N;
// for (int i = N - 1; i >=0 ; i--)
// {
//     Console.Write(massive[i] + " ");
// }
// double near = massive.OrderBy(a => Math.Abs(a - avg)).First();  
// Console.WriteLine($"\nСреднее: {avg} ближайшее число: {near}");

//Задание 2

// Console.WriteLine("Кол-во студентов: ");
// int s = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Кол-во оценок: ");
// int g = Convert.ToInt32(Console.ReadLine());
// int[,] massive = new int[s,g];

// for (int i = 0; i < s; i++)
// {
//     Console.WriteLine($"Студент {i+1}");
//     for (int j = 0; j < g; j++)
//     {
//         massive[i, j] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// for (int i = 0; i < s; i++)
// {
//     double sum = 0;
//     for (int j = 0; j < g; j++)
//     {
//         sum += massive[i,j];
//     }
//     double avg = sum / g;
//     Console.WriteLine($"Студент {i+1} Средняя оценка {avg}");
// }

//Задание 3

// List<int> num = new List<int>();
// while (true)
// {
//     int n = Convert.ToInt32(Console.ReadLine());
//     if (num.Contains(n))
//     {
//         break;
//     }
//     num.Add(n);
// }
// foreach(int i in num)
// {
//     Console.Write(i + " ");
// }

// Задание 4
// Dictionary<string, string> massive = new Dictionary<string, string>();
// while (true)
// {
//     Console.WriteLine("Команды: добавить, выход, поиск, показать");
//     string com = Console.ReadLine();
//     if (com == "выход")
//     {
//         break;
//     }

//     if (com == "добавить")
//     {
//         Console.Write("Имя: ");
//         string n = Console.ReadLine();
//         Console.Write("Телефон: ");
//         massive[n] = Console.ReadLine();
//     }
//     else if (com == "поиск")
//     {
//         Console.Write("Имя: ");
//         string n = Console.ReadLine();
//         Console.WriteLine(massive.ContainsKey(n) ? massive[n]:"Не найдено!");
//     }
//     else if (com == "показать")
//     {
//         foreach(var i in massive)
//         {
//             Console.WriteLine($"{i.Key} - {i.Value}");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Нет такой команды!");
//     }
// }

//Задание 5
Dictionary<string, int> fruits = new Dictionary<string, int>();
string[] a = {"яблоко", "банан", "яблоко", "груша", "банан", "слива"};

foreach(var i in a)
{
    if (fruits.ContainsKey(i))
    {
        fruits[i]++;
        Console.WriteLine($"Слово {i} есть. Теперь количество - {fruits[i]}");
    }
    else
    {
        fruits.Add(i, 1);
        Console.WriteLine($"Новое слово {i} добавлено.");
    }
}
foreach(var j in fruits)
{
    Console.WriteLine($"{j.Key} - {j.Value}");
}