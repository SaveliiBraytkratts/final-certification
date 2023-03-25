void CreationArray(string[] arrey)
{
    Console.WriteLine("Введите строки :");
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = Console.ReadLine()!;
    }
}
Console.WriteLine("Введите количество строк:");
int n = int.Parse(Console.ReadLine()!);
string[] stringArray = new string[n];
CreationArray(stringArray);