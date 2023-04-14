/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int N;
Console.WriteLine("Введите натуральное число:");
int.TryParse(Console.ReadLine(), out N);
Console.Write(OutNumbers(N));
string OutNumbers (int N){
    if (N<2){
        return $"{1}";}
    else {return $"{N}, {OutNumbers(N-1)}";}
}