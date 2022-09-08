// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь: 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3.

int[] arrayNum = new int[6];
int count = 0;

Console.WriteLine("Введите 6 чисел:");

arrayNum[0] = Convert.ToInt32(Console.ReadLine());
arrayNum[1] = Convert.ToInt32(Console.ReadLine());
arrayNum[2] = Convert.ToInt32(Console.ReadLine());
arrayNum[3] = Convert.ToInt32(Console.ReadLine());
arrayNum[4] = Convert.ToInt32(Console.ReadLine());
arrayNum[5] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < arrayNum.Length; i++)
{
    if (arrayNum[i] > 0) count++;
}
Console.WriteLine($"Чисел больше ноля: {count}");