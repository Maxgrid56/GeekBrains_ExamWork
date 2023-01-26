int[] array = new int[4] { 6542, 897, 54, 3452 };
int[] finalArray = new int[2];

for (int i = 0; i < finalArray.Length; i++)
 {
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j]<1000)
        {
             finalArray[i] = array[j];
             int index = Array.IndexOf(array, array[j]);
        array = array.Where((e, i) => i != index).ToArray();
            break;
        }
    }
 }
var str = string.Join(" ", finalArray);
Console.WriteLine(str);