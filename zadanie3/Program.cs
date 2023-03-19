





void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0,2);
}

Console.Clear();
int [] array = new int[8];
InputArray(array);

Console.WriteLine($"[{string.Join(", ", array)}]");