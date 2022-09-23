int[] array = {1, 12, 51, 32, 62, 45, 62, 123};
int n = array.Length;
int find = 123;
int index = 0;
while(index<n)
{
    if(array[index] == find)
        {
            Console.WriteLine(index);
            break; // заканчивает алгоритм
        }
        index++;
}
