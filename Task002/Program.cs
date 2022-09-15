Console.WriteLine("Введите первое число: ");
string A = Console.ReadLine();
int numberA = int.Parse(A);

Console.WriteLine("Введите второе число: ");
string B = Console.ReadLine();
int numberB = int.Parse(B);

int C = numberB * numberB;
//Console.WriteLine(C);

if (C == numberA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}