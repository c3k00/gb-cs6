// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите несколько чисел, через запятую:");
int[] n = Console.ReadLine().Split(new char []{',', '\t'}, StringSplitOptions.RemoveEmptyEntries).Select(e => Convert.ToInt32(e)).ToArray();
int t = 0;

for (int i = 0; i < n.Length; i++)
{
    if (n[i] > 0)
    {
    t++;
    }
}
// Console.WriteLine(String.Join(" ", n));
Console.WriteLine("-> " + t);
