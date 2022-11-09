// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int controlSize = 3;
string[] myArray = FillArray();
PrintArray(myArray);
Console.WriteLine();
string[] myNewArray = getNewArray(myArray);
PrintArray(myNewArray);

string[] FillArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"'{array[i]}', ");
        else
            Console.Write($"'{array[i]}'");
    }
    Console.WriteLine("]");
}

string[] getNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= controlSize)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref newArray, j);
    return newArray;
}


//Второй вариант решения задачи.

Console.WriteLine();
PrintArray(getNewArraySecondWay(myArray));

int getSizeNewArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= controlSize)
        {
            size++;
        }
    }
    return size;
}

string[] getNewArraySecondWay(string[] array)
{
    string[] newArray = new string[getSizeNewArray(myArray)];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= controlSize)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}