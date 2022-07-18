using System.Linq; //библеотека Linq
string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "") // замена символа
                .Replace(")", "");
Console.WriteLine(text);
var data = text.Split(" ") //разбиение разделителем - пробел
                .Select(item => item.Split(",")) //выборка элемента и разбиение его запятой
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) //выбранный элемент разбиваем на числовые координаты
                .Where(e => e.x % 2 == 0) //случай, когда координата четная
                .Select(point => (point.x * 10, point.y)) //выбираем точку и меняем ей координату х, увеличивая в 10 раз
                .ToArray(); //создаем массив из элементов

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
}