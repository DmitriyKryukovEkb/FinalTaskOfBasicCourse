// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string ReadString(string msg) // Функция для чтения строки, введенной пользователем.
{
    System.Console.WriteLine(msg);
    string inputString = Console.ReadLine();
    return inputString;
}

int ReadInt(string msg) // Функция для чтения числа, введенного пользователем.
{
    int number = int.Parse(ReadString(msg)); 
    return number; 
}

string[] InputMassive(int len) // Функция создания массива строк, вводимых пользователем. Нужно передать длину массива.
{   
    System.Console.WriteLine($"Формируем массив из {len} строк: ");
    string[] resultMassive = new string[len];
    for (int i = 0; i < len; i++)
    {
        resultMassive[i] = ReadString($"Введите {i + 1} строку: ");
    }
    return resultMassive;
}

void printMassive(string[] massive) // Функция вывода массива на экран.
{
    foreach (string item in massive)
    {
        Console.Write(item + "\t");
    }
}

int resultLength = 0;
int filterLength = 3;
int massiveLength = ReadInt("Введите длину исходного массива: ");
string[] inputMassive = InputMassive(massiveLength);

foreach (string item in inputMassive)
{
    if (item.Length <= filterLength)
    {
        resultLength ++;
    }
}

string[] resultMassive = new string [resultLength];
int j = 0;

foreach (string item in inputMassive)
{
    if (item.Length <= filterLength)
    {
        resultMassive[j] = item;
        j ++;
    }
}

System.Console.WriteLine("Результат: ");
printMassive(resultMassive);
