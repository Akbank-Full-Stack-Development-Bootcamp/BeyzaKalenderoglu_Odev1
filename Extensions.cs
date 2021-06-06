using System;
public static class Extension{

    public static void throwDice(){

        Random rand = new Random();

        Console.WriteLine("*** Throw Dice ****");

        for (int i = 0; i <= 1; i++){
            Console.Write("{0,4:N0}", rand.Next(1, 7));
            
        }
        Console.WriteLine();
    }   
        
    public static void CoinFlip(){

        Random rand = new Random();

        Console.WriteLine("*** Coin Flip ****");

        if (rand.Next(2) == 0)
            System.Console.WriteLine("   Head");
        else   
            System.Console.WriteLine("   Tail");

    }
}