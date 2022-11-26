int min_length = 3;
int size_array = 3;
string[] array_base = new string[size_array];
Console.WriteLine($"Введите произвольные строковые элементы в количестве {size_array} раз для определения элементов не более {min_length} символов");
FillArray(array_base);
Console.Clear();

PrintArray(array_base);
Console.WriteLine("Новый массив с элементами, удовлетворяющими условия: ");
if (GetNewArray(array_base) ==0){Console.WriteLine("Нет подходящих для условия задачи данных");}
else
{
    string[] array_new = MoveData(array_base);
    PrintArray(array_new);
}

void FillArray (string[] arr)
{
    for (int i = 0; i < size_array; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}

void PrintArray (string[] arr)
{
    size_array = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < size_array; i++)
    {
        Console.Write (arr[i] + " ");
    }
    Console.WriteLine("]");
}

int GetNewArray(string[] arr)
{
    int second_size = 0;
    for (int i = 0; i < size_array; i++)
    {
        if(arr[i].Length <= min_length)
        {
            second_size++;
        }
    }
    return second_size;
}

string[] MoveData(string[] arr)
{
    string[] array_new = new string[GetNewArray(array_base)];
    for (int i = 0, j = 0; i < size_array; i++)
    {
        if(arr[i].Length <= min_length)
        {
            array_new[j] = arr[i];
            j++;
        }
    }
    return array_new;
}