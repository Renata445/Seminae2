Console.Clear();

int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгерируемое число: {number}");
int n3 = number % 10; 
int n1 = number/100;
int result = n1 * 10 + n3;

Console.WriteLine(result);

