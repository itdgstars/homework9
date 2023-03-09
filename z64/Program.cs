void ShowNumbers(int number)
{
    Console.Write(number + " ");
    if (number > 1) ShowNumbers(number - 1);
    

    
}
Console.Write("Укажите Ваше число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
ShowNumbers(numN);

