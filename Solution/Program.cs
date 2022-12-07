int getSize(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] makeNewArray(string[] array)
{
    string[] newArray = new string[getSize(array)];
    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void showArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");        
    }
    Console.WriteLine();
}

Console.Write("Input the size of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] myArray = new string[n];
for(int i = 0; i < n; i++)
{
    Console.Write($"Input the {i + 1} element of the array: ");
    myArray[i] = Console.ReadLine();
}

Console.WriteLine("Original array:");
showArray(myArray);

string[] newArray = makeNewArray(myArray);
Console.WriteLine("New array:");
showArray(newArray);
