// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Четныe числа от 1 до N: ");
for (int i = 2; i <= N; i+=2)
{
    Console.WriteLine(i);
}
Console.ReadLine();
