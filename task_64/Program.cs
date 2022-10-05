Console.WriteLine("Программа, которая выводит все натуральные числа от N до 1");

Console.WriteLine("Введите N");
int number = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(number);

void PrintNumbersToN(int N)
{
    if (N < 1) return;
    Console.Write(N + "");
    PrintNumbersToN(N - 1);
    
}