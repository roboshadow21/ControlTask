int ArrayElementsLengthCounter(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
        else continue;
    }
    return count;
}

string[] NewStringArray(string[] collection, int count)
{
    string[] array = new string[count];
    int j = 0;
    for (int i = 0; i < collection.Length; i++)
    {
       if (collection[i].Length <= 3) 
       {
           array[j] = collection[i];
           j++;
       }
    }
    return array;
}

string[] myStringArray = {"1234", "1567", "-2", "computer science"};
int counter = ArrayElementsLengthCounter(myStringArray);
string[] newArray = NewStringArray(myStringArray, counter);

// for (int i = 0; i < newArray.Length; i++)
// {
//     Console.Write(newArray[i] + " ");
// }  
