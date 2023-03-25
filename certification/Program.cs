void CreationArray(string[] arrey)
{
    Console.WriteLine("Введите строки :");
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = Console.ReadLine()!;
    }
}
string[] stringArray = new string[4];
CreationArray(stringArray);