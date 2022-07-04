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
Console.WriteLine();
Console.WriteLine("Input array:");
for (int i=0;i<inputArray.Length;i++)
    Console.Write($" '{inputArray[i]}' ");

//Searching strings, which contain three or less chars
int outputLengthArray = 0;
for (int i = 0; i < inputArray.Length; i++)
    if (inputArray[i].Length <= 3) outputLengthArray++;
string[] outputArray = new string[outputLengthArray];
int j = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        outputArray[j] = inputArray[i];
        j++;
    }
}
Console.WriteLine();
Console.WriteLine("Output array, which strings contain three or less chars:");
for (int number=0; number<outputArray.Length; number++)
    Console.Write($" '{outputArray[number]}' ");