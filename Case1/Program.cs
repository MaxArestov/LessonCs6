// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();
int[] numbersTriang = new int[3];
FillArray(numbersTriang);
PrintArray(numbersTriang);
Console.WriteLine(CheckTriangle(numbersTriang));







void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 21);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
bool CheckTriangle(int[] array)
{
    if (array[0] < (array[1] + array[2]) && array[1] < (array[0] + array[2]) && array[2] < (array[0] + array[1]))
    {
        return true;
    }
    else return false;
}