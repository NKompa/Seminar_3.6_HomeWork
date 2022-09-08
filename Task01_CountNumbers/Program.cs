// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь: 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3.

int[] Numbers = new int[6];
int countNumbers = 0;

Console.WriteLine("Введите 6 чисел:");

for (int i = 0; i < Numbers.Length; i++)
{
    Numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (Numbers[i] > 0) countNumbers++;
}
Console.WriteLine($"Чисел больше ноля: {countNumbers}");