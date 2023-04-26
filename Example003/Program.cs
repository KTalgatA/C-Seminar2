// Напишите программу, которая будет принимать на вход два числа и
// выводить , является ли второе число кратным первому. Если число 2 не
// кратно число 1, то программа выводит остаток от деления.
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно

Console.Clear();

int varA;
while (true)
{
  Console.Write("Введите A: ");
  if (int.TryParse(Console.ReadLine(), out varA))
    break;
  Console.WriteLine("Ошибка ввода!");
}
Console.WriteLine($"A={varA}");

int varB;
while (true)
{
  Console.Write("Введите B: ");
  if (int.TryParse(Console.ReadLine(), out varB))
    break;
  Console.WriteLine("Ошибка ввода!");
}
Console.WriteLine($"B={varB}");
int r = varA % varB;
if (varA % varB == 0)
{
  Console.WriteLine($"{varA}, {varB} -> Кратно");
}
else
{
  Console.WriteLine($"{varA}, {varB} -> Не кратно, остаток {r}");
}