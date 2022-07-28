
// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в 
//промежутке от M до N.

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (m <= n) {
    sum = sum + m;
    m++;
}
Console.WriteLine(sum);