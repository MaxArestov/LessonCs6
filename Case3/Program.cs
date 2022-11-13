// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.
Console.Clear();
int[] arrayForCopy = new int[15];
FillArray(arrayForCopy);
PrintArray(arrayForCopy);
int[] copyedArray = CopyArray(arrayForCopy);
PrintArray(copyedArray);
copyedArray[0] = 11111;
PrintArray(arrayForCopy);
PrintArray(copyedArray);


int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}
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