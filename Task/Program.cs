// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

void SelectionArray(string[] array, string[]newArray)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3) newArray[i] = array[i];
        Console.Write($"{newArray[i]} ");
    }
}

string[] arr = new string[9] {"оn", "1235", "the", "sun", "clock", "+30", "melody", "?", "yes"};
string[] newArr = new string[arr.Length];
SelectionArray(arr, newArr);

