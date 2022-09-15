Console.Clear();

Console.WriteLine("Введите трёхзначное число: ");
string A = Console.ReadLine();
int numberA = int.Parse(A);
numberA = Math.Abs(numberA);

Console.WriteLine(numberA % 10);

if((numberA > 99) & (numberA < 1000))
{
    Console.WriteLine(numberA % 10);
} 
else
{
    Console.Write("Не трёхзначное число");
}

