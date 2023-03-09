int SumDigits (int m, int n)
{   
    
    if (m < 0) m *= -1;
   
    if (m <= n)
    {
        
        return SumDigits (m+1,n) + m;
    } 
    
    else return 0;
   
    
    
}
Console.WriteLine("Введите число M");
int muser = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите число N");
int nuser = Convert.ToInt32(Console.ReadLine ());

int res = SumDigits (muser, nuser);
Console.WriteLine(res);
