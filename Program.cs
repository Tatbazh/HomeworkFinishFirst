//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.
// Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] FindElementFromArray(string[] words)
{
    string[] words2 = new string[words.Length];
    int counter = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3)
        {
            words2[counter] = words[i];
            counter++;
        }       
    }
    return words2;
}
// string[] words = { "1234", "1567", "-2", "computer science" };
// string[] words = { "Russia", "Denmark", "Kazan" };
string[] words = { "Hello", "2", "world", ":-)" };
Console.Write(String.Join(" ", words));
Console.WriteLine();
Console.Write(String.Join(" ",FindElementFromArray(words)));