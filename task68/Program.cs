int LeviAckerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return LeviAckerman(n - 1, 1);
    else
      return LeviAckerman(n - 1, LeviAckerman(n, m - 1));
}

Console.Clear();
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Значение m = {m};\tзначение n = {n}.");
Console.WriteLine($"\nA(m,n) = {LeviAckerman(m, n)}\n");