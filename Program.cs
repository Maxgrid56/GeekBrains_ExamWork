string[] array = { "Здравия желаю", "54", "LOL", "342", "5896" };
string[] finalArray = new string[3];

for (int i = 0; i < finalArray.Length; i++)
 {
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].ToString().Length <4)
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