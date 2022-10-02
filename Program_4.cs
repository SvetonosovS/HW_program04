Console.Write("Введите целое первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите целое второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

Console.Write("Введите целое третье число: ");
string userInput3 = Console.ReadLine() ?? "";
int userNumber3 = int.Parse(userInput3);

int Maximum = userNumber1;
if (userNumber2 > Maximum)
{
    Maximum = userNumber2;
}
if (userNumber3 > Maximum)
{
    Maximum = userNumber3;
}
 Console.WriteLine(userNumber1 + ";" + userNumber2 + ";" + userNumber3 + " -> " + Maximum);