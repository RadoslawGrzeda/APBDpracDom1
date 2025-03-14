// See https://aka.ms/new-console-template for more information
int[] arr = {2,2,2 };
Console.WriteLine(average(arr));



 static int average(int[] array)
{
int sum = 0;
int howMany = array.Length;
for(int i = 0; i < howMany; i++)
  sum += array[i];

return sum / howMany;
}