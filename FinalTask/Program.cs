void CreatArrayOfStrins(string[] Array)
{
    string[] NewArray = new string[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            NewArray[i] = Array[i];
            Console.Write($"{NewArray[i]} ");
        }
    }
    Console.WriteLine();
}
void PrintArrayOfStrings(string[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write($"{Arr[i]}, ");
    }
    Console.Write($" -> ");
}

string[] MyArray = {"один", "два", "три", "четыре", "пять", "шесть", "1", "22", "333", "4444"};
PrintArrayOfStrings(MyArray);
CreatArrayOfStrins(MyArray);

