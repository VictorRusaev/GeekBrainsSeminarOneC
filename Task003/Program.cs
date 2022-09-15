Console.Clear();

Console.WriteLine("Введите число от 1 до 7: ");
string A = Console.ReadLine();
int numberA = int.Parse(A);

if (numberA == 1) Console.Write("Понедельник");
if (numberA == 2) Console.Write("Вторник");
if (numberA == 3) Console.Write("Среда");
if (numberA == 4) Console.Write("Четверг");
if (numberA == 5) Console.Write("Пятница");
if (numberA == 6) Console.Write("Суббота");
if (numberA == 7) Console.Write("Воскресенье");
if (numberA > 7) Console.Write("Нет такого дня недели");
if (numberA < 1) Console.Write("Нет такого дня недели");