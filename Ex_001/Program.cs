// Задайте значения М и N. Напишите программу, которая выведет
// все четные натуральные числа в промежутке от М до N с помощью
// рекурсии.

int Promt(string message)                        
{
    Console.Write(message);                 
    return Convert.ToInt32(Console.ReadLine());    
}

void PrintNumbers(int number)
{
    if(number < 1)                   
    {
        return;
    } 
    if(number%2 == 0)            
    {
    PrintNumbers(number - 2);
    Console.Write($"{number}; ");
    }
    else 
    {
    number -= 1;
    PrintNumbers(number - 2);
    Console.Write($"{number}; ");
    }
}

int number = Promt("Введите число: ");
PrintNumbers(number);