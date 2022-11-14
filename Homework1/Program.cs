Console.Write("Введите число a: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите число b: ");
string userInput2 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);
if (number1 < number2)
{
  Console.Write($"a = {number1}, b = {number2} -> max = {number2}");
}
else
{
  Console.Write($"a = {number1}, b = {number2} -> max = {number1}");
}
