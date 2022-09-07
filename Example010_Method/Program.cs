int[] array = { 12, 654, 123, 21, 45, 3, 13, 13 };

int n = array.Length;
int find = 13;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index=index+1
    index++;
}