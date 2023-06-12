// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
//-постановка задачи;
Console.Write("!1! - Задайте значения M и N\n!2! - найдёт сумму натуральных элементов\n!3! - в промежутке от M до N.");

//-!1! - Задайте значения M и N
int Prompt(string message)
{
    int result = 0;
        try
        {
            Console.Write(message);
            result = int.Parse(Console.ReadLine());
        }
        catch{Prompt("ошибка ввода данных!"+message);}
    return result;
}
int m = Prompt("\n- Задайте значение M: ");
int n = Prompt("- Задайте значение N: ");
if(m>n) 
    {
        m = Prompt("\nУвы, условие задачи M<N,прошу Вас повторно\n- Задайте значение M: ");
        n = Prompt("- Задайте значение N: ");
    }
//-!2! - найдёт сумму натуральных элементов\n
//-!3! - в промежутке от M до N
int sum = SumFromMtoN(0,m,n);
Console.Write($"M = {m}; N = {n} -> {sum}");

int SumFromMtoN(int sum,int m, int n)
{
    if(m<=n)
    {
        sum = sum + m;
        m++;
        return SumFromMtoN(sum,m,n);
    }
    return sum;
}