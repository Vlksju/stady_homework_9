Console.WriteLine("Программа, которая выводит сумму чисел в промежутке от M до N");

Console.Write("Введите N - наименьшее ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите M - наибольшее ");
int numberM = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int N, int M)
{
    if (M == N) return N;
    
    return M + SumNumbers (N, M-1);
    
}

Console.WriteLine($"Сумма всех чисел = {SumNumbers(numberN, numberM)}");
