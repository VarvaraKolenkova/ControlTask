// Программа, которая из имеющкгося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

void SelectionArray(string[] array, string[]newarray)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3) newarray[i] = array[i];
        Console.Write($"{newarray[i]} ");
    }
}

string[] arr = new string[9] {"оn", "1235", "the", "sun", "clock", "+30", "melody", "?", "yes"};
string[] newarr = new string[arr.Length];
SelectionArray(arr, newarr);

