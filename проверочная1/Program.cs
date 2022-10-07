 
Console.WriteLine("Введите количество элементов массива (от 1 до 9):");
int n = Convert.ToInt32(Console.ReadLine());

string [] Array (int n) // метод создания  массива из введенных с клавиатуры строк
{
string [] arr = new string [n];
for (int i =0; i<n; i++)
{
    Console.WriteLine($"Введите {i + 1}элемент массива ");
    arr[i]= Console.ReadLine();
}
return arr;
}
void PrintArray (string []arr) //метод печати массива c проверкой условия
{
    Console.Write("[");
    for (int i =0; i<arr.Length; i++)
    {
        if (arr[i].Length<=3)
        {
        Console.Write($"{arr[i]}, ");
        }
    }
     Console.WriteLine("\b\b]"); //\b\b убирает , и  последний пробел
}
PrintArray(Array(n)); 


