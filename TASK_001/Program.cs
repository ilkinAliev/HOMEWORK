// написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых равна либо меньше 3 символов


Console.WriteLine("Введите любые 4 слова через Enter:"); //создаем массив
string[] stringArray = new string[4];
for (int i = 0; i < stringArray.Length; i++)
{
    stringArray[i] = Console.ReadLine();
}

List<string> ls = new List<string>();  //создаем список, куда будем добавлять прошедшие условие элементы массива
for (int i = 0; i < stringArray.Length; i++)
{
   if (stringArray[i].Length <= 3)
       ls.Add(stringArray[i]);          
}            

string[] matrix = ls.ToArray(); // формирование нового массива строк с удовлетворяющими условию элементами 

Console.Write("[ ");
for (int i = 0; i < matrix.Length; i++)
{
    Console.Write(matrix[i] + " ");
}
Console.Write("]");