Console.WriteLine("Программа, которая вычесляет функцию Аккермана");

Console.Write("Введите N ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите M ");
int numberM = Convert.ToInt32(Console.ReadLine());

int AckermannFunction (int N, int M)
{
    if (N==0) return M+1;
    else
    if ((N!= 0) && (M==0)) return AckermannFunction (N-1, 1);
    else 
    return AckermannFunction (N-1, AckermannFunction (N, M-1));
    
}

Console.WriteLine(AckermannFunction (numberN, numberM));