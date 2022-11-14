Console.Write("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);
int count = 0;
int evenNumber = 0;
Console.Write($"{number1} -> ");
while (count <= number1)
{
    evenNumber = count;
    if (evenNumber % 2 == 0 && evenNumber > 0 && evenNumber < number1)
    {
        Console.Write(evenNumber + ", ");
    }
    else if (evenNumber == number1 )
    {
        Console.Write(evenNumber);
    }
     count ++;
}