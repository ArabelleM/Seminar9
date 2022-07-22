// Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.

// Принимаем, что N всегда больше М

//using System.Runtime;

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

DateTime dateV1 = DateTime.Now;
// v1
int[] arrayMN = new int[n - m - 1];
for(int i = m + 1; i < n; i++) {
    arrayMN[i - m - 1] = i;
}
Console.WriteLine(string.Join("; ", arrayMN));
Console.WriteLine(DateTime.Now - dateV1);


DateTime dateV2 = DateTime.Now;
//v2
for(int i = m + 1; i < n; i++) {
    if (i == n - 1) Console.WriteLine(i);
    else Console.Write(i + "; ");
}
Console.WriteLine(DateTime.Now - dateV2);

DateTime dateV3 = DateTime.Now;
//v3
void RecMN (int m1, int n1) {
    if (m1 + 1 >= n1 - 1) Console.WriteLine(m1 + 1);
    else {
        Console.Write((m1 + 1) + "; ");
        RecMN (m1 + 1, n1);
    }
}
RecMN(m, n);
Console.WriteLine(DateTime.Now - dateV3);

