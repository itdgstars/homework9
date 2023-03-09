int AkkFun(int m, int n)
{
  if (m < 0 || n < 0)
  {
    Console.WriteLine ("Одно или оба ваших чисел ОТРИЦТЕЛЬНЫЕ!");
  }
  else {
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AkkFun(m - 1, 1);
    else
      return AkkFun(m - 1, AkkFun(m, n - 1));
      
}
return 0;
}

Console.Write ("Введите число М: ");
int userm = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число N: ");
int usern = Convert.ToInt32(Console.ReadLine());

int res = AkkFun(userm, usern);
Console.WriteLine(res);

