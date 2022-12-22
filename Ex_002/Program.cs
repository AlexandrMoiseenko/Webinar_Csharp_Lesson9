// Задайте значения М и N. Напишите программу, которая найдет сумму натуральных
// элементов в промежутке от М до N с помощью рекурсии.

int Promt(string message)                        
{
    Console.Write(message);                 
    return Convert.ToInt32(Console.ReadLine());    
}

int Sum(int numberStart, int numberFinish)
{
    if(numberStart == numberFinish)
    {
        return numberStart;
    }
    return numberStart + Sum(numberStart + 1, numberFinish);
}

int numberStart = Promt("Введите начальное число: ");
int numberFinish = Promt("Введите конечное число: ");
Console.WriteLine(Sum(numberStart, numberFinish));