// Функция Аккермана


Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman (int m, int n) {
    if (n == 0) return m + 1;
    else {
        if ((n > 0) && (m == 0)) return Akkerman(1, n - 1);
        else return Akkerman(Akkerman(m - 1, n), n - 1);
    }
}

int A = Akkerman(m, n);
Console.WriteLine(A);