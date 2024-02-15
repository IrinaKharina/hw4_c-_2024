/*
Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
5 12 16 q [STOP]
3 45 342 15 [STOP]
*/
//функция принимает на вход строку проверяет в себе условия на остановку цикла и возвращает ответ можно остановить или нет

/*
bool AskNumber(string st)
{
    bool flag = false;
    if (st == "q")
    {
        flag = true;
    }
    else if (st.Length > 1)
    {
        if (SumElement(st) % 2 == 0) flag = true;
    }
    return flag;
}

int SumElement(string st)
{
    int c = 0;
    for (int i = 0; i < st.Length; i++) c = c + (int)Char.GetNumericValue(st[i]);//st[i];
    return c;
}

Console.Clear();
string s = "";
string s1 = "";
while (true)
{
    s = Console.ReadLine();
    Console.Clear();
    s1 = s1 + s + " ";
    Console.Write(s1);
    if (AskNumber(s))
    {
        Console.Write($"[STOP]");
        break;
    }
}
/**/

//========================================================================================================================
/*
Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[344 452 341 125] => 2
*/

/*
int NumberEven(int[] array, int NumbElem)
{
    int NumEv = 0;
    for (int i = 0; i < NumbElem; i++)
    {
        if (array[i] % 2 == 0) NumEv++;
    }
    return NumEv;
}

Console.Clear();
Random rand = new Random();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = rand.Next(100, 1000);

    if (n == 1) Console.Write($"[{arr[i]}] => ");
    else if (i == 0)
    {
        Console.Write($"[{arr[i]} ");
    }
    else if (i == n - 1)
    {
        Console.Write($"{arr[i]}] => ");
    }
    else Console.Write($"{arr[i]} ");
}
int NumberOfEvenNumbers = NumberEven(arr, n);
Console.WriteLine($"{NumberOfEvenNumbers}");
/**/

//Console.Write(123%10);
/**/
//========================================================================================================================
/*
Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
[1 3 5 6 7 8] => [8 7 6 5 3 1]
*/


int FindNumMax(int[] array, int NumbElem, int begin)
{
    int max = array[begin];
    int num = begin;
    for (int i = begin;i < NumbElem;i++)
    {
        if (array[i] > max) {
            max = array[i];
            num = i;
        }
    }
    return num;
}

void PrintMas(int[] array, int NumbElem)
{
    Console.Write($"[{array[0]}");
    for (int i = 1;i < NumbElem; i++) Console.Write($" {array[i]}");
    Console.Write("]");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
Random rand = new Random();
int[] arr = new int[n];

for(int i = 0;i < n;i++)  arr[i] = rand.Next(1,10);

PrintMas(arr,n);
int elem = 0;
int number = 0;

for(int i = 0;i < n-1;i++){
    number = FindNumMax(arr, n, i);
    elem = arr[i];
    arr[i] = arr[number];
    arr[number] = elem;
}

Console.Write(" => ");
PrintMas(arr,n);
/**/