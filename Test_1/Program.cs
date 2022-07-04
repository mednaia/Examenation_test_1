// Написать программу, которая из имеющегося массива строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Creation of input array
Console.Write("Enter number of strings: ");
int lengthInputArray=int.Parse(Console.ReadLine()??"0");
string[] inputArray = new string[lengthInputArray];
for (int i=0;i<inputArray.Length;i++)
    {
        Console.WriteLine("Enter your strings: ");
        inputArray[i]=Console.ReadLine()??"0";
    }
for (int i=0;i<inputArray.Length;i++)
    Console.Write($" '{inputArray[i]}' ");

  