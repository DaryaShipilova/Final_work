// Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. 

string[] array = new string[6] { "123", "go", "hello", "1234", "12", "good morning" };
string[] newArray = new string[array.Length];

void FillnewArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write($" Новый массив, где количество символов <= 3 - ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}
FillnewArray(array, newArray);
PrintArray(newArray);