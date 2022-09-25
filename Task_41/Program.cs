// 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите целые числа через пробел: ");
string input = Console.ReadLine()!;
string[] numbers = input.Split(' ');
int[] nums = GetArrayOfNumbers(numbers);
Console.WriteLine(CountPositives(nums));

int[] GetArrayOfNumbers(string[] array)
{
    int size = array.Length;
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = int.Parse(array[i]);
    }
    return numbers;
}

int CountPositives(int[] array)
{
    int result = 0;
    foreach (int number in array)
    {
        if (number > 0) result += 1;
    }
    return result;
}