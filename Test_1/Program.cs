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
        Console.WriteLine($"Enter string number {i+1}: ");
        stringArr[i]=Console.ReadLine()??"0";
    }   
}

void PrintArrayOfStrings(string[] arrayOfStrins)
{
    for (int i=0;i<arrayOfStrins.Length;i++)
    Console.Write($" '{arrayOfStrins[i]}' ");
}

int DefineLengthOfOutputArray(string[] arrayStr)
{
int number=0;
for(int index=0;index<arrayStr.Length;index++)
    if (arrayStr[index].Length<=3)
        number++;
return number;
}

void FillOutputArray(string[] arrInput, string[] arrOutput)
{
int j = 0;
    for (int i = 0; i < arrInput.Length; i++)
    {
        if (arrInput[i].Length <= 3)
        {
            arrOutput[j] = arrInput[i];
            j++;
        }
    }
}


Console.Clear();
Console.Write("Enter your number of strings: ");
int lengthInputArray=int.Parse(Console.ReadLine()??"0");
string[] inputArray=CreateArrayOfStrings(lengthInputArray);
FillArrayOfStrings(inputArray);
Console.WriteLine($"Input array: ");
PrintArrayOfStrings(inputArray);
Console.WriteLine();
int lengthOfOutputArray=DefineLengthOfOutputArray(inputArray);
if (lengthOfOutputArray>0)
{
    string[] outputArray=CreateArrayOfStrings(lengthOfOutputArray);
    FillOutputArray(inputArray,outputArray);
    Console.WriteLine("Output array, which strings contain three or less chars:");
    PrintArrayOfStrings(outputArray);    
}
else
{
    Console.WriteLine("Input array contain strings, which length more, than three chars.");
}





