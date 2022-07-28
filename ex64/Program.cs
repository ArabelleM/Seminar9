// Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.

// Принимаем, что N всегда больше М



Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());


// v1
int[] arrayMN = new int[n - m + 1];
for(int i = m; i < n + 1; i++) {
    arrayMN[i - m] = i;
}
Console.WriteLine(string.Join("; ", arrayMN));

//v2
for(int i = m; i < n + 1; i++) {
    if (i == n ) Console.WriteLine(i);
    else Console.Write(i + "; ");
}

//v3
void RecMN (int m1, int n1) {
    if (m1 == n1) Console.WriteLine(m1);
    else {
        Console.Write((m1) + "; ");
        RecMN (m1 + 1, n1);
    }
}
RecMN(m, n);

//v4
while (m <= n) {
    if (m == n) Console.WriteLine(m);
    else Console.Write(m + "; ");
    m++;
}