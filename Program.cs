using System;
                    
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Crin: Welcome! Popcorn is £10, Please insert cash here: ");
        
        int cash =     Convert.ToInt32(Console.ReadLine());
        
        if (cash < 10)
        {
        Console.WriteLine("Card Declined.");
        Console.WriteLine("Crin: Sorry Mate, guess you can't enjoy your popcorn.");
        
        }    
        else
        {
        Console.WriteLine("Card Approved.");
        Console.WriteLine("Crin: Enjoy!");
        }    
        
    }
}