int n = 3;
string[] arrayStart = SetElements();
string[] arrayEnd = NewArray(arrayStart,n);
PrintArray(arrayEnd);

string[] SetElements()
{
Console.WriteLine($"Enter the elements separated by commas");
string[] array = Console.ReadLine().Split(",");
return array;
}

int CountElementsNoMoreN(string[] array, int lenghtElements)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= lenghtElements)
    {
        count++;
    }
}
return count;
}

string[] NewArray(string[] array, int lenghtElements)
{
string[] arrayNew = new string[CountElementsNoMoreN(array, lenghtElements)];
for (int i = 0, j = 0;  i < array.Length; i++)
{
    if (array[i].Length <= lenghtElements)
    {
        arrayNew[j] = array[i];
        j++;
    }
    
}
return arrayNew;
}

void PrintArray(string[] arr)
{
    System.Console.Write($"[{String.Join(", ", arr)}]");
}
