
// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в 
//промежутке от M до N.

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int RecSum (int m1, int n1) {
    if (m1 == n1) return m1;
    else return n1 + RecSum(m1, n1 - 1);
    
}

Console.WriteLine(RecSum(1, 11));