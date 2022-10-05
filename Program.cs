//Задача : Напишите программу, которая из имеющегося массива
// строк формирует массив из строк, длина которых равна меньше или равна три символа
//Перевоначальный массив можно ввести с клавиатуры либо задать
// на старте выполнения алгоритма

using static System.Console;
Clear();

string[] arr =

{
    "hello", "2", "world", ":-)",
    "Russia", "Denmark", "-2",  "1234", "1567",
    "computer  science",
};
string[] GetValidArray(string[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)        