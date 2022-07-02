// Вид 2
/*void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}
//Method2("Текст ", 4);
Method2(count: 4, msg: "новый текст");*/

// Вид 3
/*int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);*/

// Вид 4
/*string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i =0;i < count;i ++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "what");
Console.WriteLine(res);*/

// Цикл в цикле - Пример для таблицы умножения
/*for (int i = 2;i <= 10;i++)
{
    for (int j = 2;j <= 10;j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}*/

/*Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.*/
/*string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text,' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'с', 'С');
Console.WriteLine(newText);
*/

//Упорядочивание массива
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void printArray(int [] array)
{
    int count = array.Length;
    for (int i =0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
printArray(arr);
SelectionSort(arr);
printArray(arr);