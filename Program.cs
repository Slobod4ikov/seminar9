/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int M, N;
Console.WriteLine("Введите число M, M < N:");
int.TryParse(Console.ReadLine(), out M);
Console.WriteLine("Введите число N, N > M:");
int.TryParse(Console.ReadLine(), out N);
Console.Write(SumNumbers(M, N));
int SumNumbers (int M, int N){
    while (M<N+1)
    {
      return M+SumNumbers(M+1,N);  
    }
    return 0;
}