Console.Clear();
Console.WriteLine("Введите 1-ое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if(n1 * n1 == n2 || n2 * n2 == n1)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
