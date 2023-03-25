void CreationArray(string[] arrey)
{
    Console.WriteLine("Введите строки :");
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = Console.ReadLine()!;
    }
}
void CheckingStork(string[] arr, string[] ar)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            ar[i] = arr[i];
            Console.WriteLine(ar[i]);
        }
    }
}
Console.WriteLine("Введите количество строк:");
int n = int.Parse(Console.ReadLine()!);
string[] stringArray = new string[n];
string[] stringArray2 = new string[n];
CreationArray(stringArray);
Console.WriteLine("массив из сторк, длина котрых меньше или ровна 3 символа");
CheckingStork(stringArray, stringArray2);