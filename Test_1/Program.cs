// Написать программу, которая из имеющегося массива строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[]CreateArrayOfStrings(int count)
{
    return new string[count];
}

void FillArrayOfStrings(string[] stringArr)
{
    for (int i=0;i<stringArr.Length;i++)
    {
        stringArr[i]=Console.ReadLine()??"0";
    }   
}

void PrintArrayOfStrings(string[] arrayOfStrins)
{
    for (int i=0;i<arrayOfStrins.Length;i++)
    Console.Write($" '{arrayOfStrins[i]}' ");
}

Console.Clear();
Console.Write("Enter your number of strings: ");
int lengthInputArray=int.Parse(Console.ReadLine()??"0");
string[]inputArray=CreateArrayOfStrings(lengthInputArray);
Console.WriteLine("Enter your strings: ");
FillArrayOfStrings(inputArray);
Console.WriteLine($"Input array: ");
PrintArrayOfStrings(inputArray);
Console.WriteLine();



