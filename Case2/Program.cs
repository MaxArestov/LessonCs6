// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
// 1.
// Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
int nFibon = GetNumber();
int[] fibonArray = CurvFibonacci(nFibon);
PrintArray(fibonArray);





int GetNumber()
{
    Console.WriteLine("Введите целое число:");
    bool checkIsDigit = true;
    int number = 0;
    while (checkIsDigit)
    {
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Введены некорректные данные. Введите целое число:");
        }
        else checkIsDigit = false;
    }
    return number;
}
int[] CurvFibonacci(int num)
{
    int count = 0;
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}