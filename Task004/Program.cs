Console.Clear();

Console.WriteLine("Введите целое число: ");
string A = Console.ReadLine();
int numberA = int.Parse(A);

int i = -numberA;
//Console.Write(i);

while (i <= numberA)
{
    Console.Write(i);
    Console.Write(", ");
    i++;
}
