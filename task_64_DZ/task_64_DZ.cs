// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
//-постановка задачи
Console.WriteLine("!1! - Задайте значение N,\n!2! - выведет все натуральные числа\n!3! - в промежутке от N до 1\n!4! - N = 5 -> 5, 4, 3, 2, 1\n");

//-!1! - Задайте значение N
int n  = Prompt("!1! - Задайте значение N: ");
int Prompt(string message)
{
    int result = 0;
        try
        {
            Console.Write(message);
            result = int.Parse(Console.ReadLine());
        }
        catch{result  = Prompt("ошибка ввода данных, повторите- Задайте значение N: "); }
    return result;
}
//-!2! - выведет все натуральные числа 
//-!3! - в промежутке от N до 1
string result = "-задача выполнена!";
Console.Write("N = " + n + " -> ");
result = result + NumSeriesNegativ(n);
Console.Write(result);
string NumSeriesNegativ(int somenum)
{
    string result = " ";
        if(somenum>0)
        {
            Console.Write(somenum + ", ");
            somenum--;
            result = result + NumSeriesNegativ(somenum);
        }
    return result;
}

