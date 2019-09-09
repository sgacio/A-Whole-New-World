using System;

namespace A_Whole_New_World
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1.0;
      var max = 100.0;
      var iGuessed = false;


      Console.WriteLine("Would you like to play the number guessing game?");
      Console.WriteLine("Type -- yes -- and press enter to play the game");
      var play = Console.ReadLine();
      if (play == "yes")
      {
        iGuessed = false;
      }
      else
      {
        Environment.Exit(0);
      }





      while (!iGuessed)
      {
        var guess = Math.Floor((min + max) / 2);
        Console.WriteLine($"Is this your number? -- {guess}");
        Console.WriteLine("If the number is higher type out -- higher -- and press enter");
        Console.WriteLine("If the number is lower type out -- lower -- and press enter");
        Console.WriteLine("If this is your number type -- yes -- and press enter");
        var isItRight = Console.ReadLine();
        if (isItRight == "yes")
        {
          iGuessed = true;
          Console.WriteLine("I have successfully guessed your number, I win, try again?");
          Console.WriteLine("If you would like to continue type -- yes -- and press enter");
          Console.WriteLine("If you would not like to continue type -- no -- and press enter");
          var tryAgain = Console.ReadLine();
          if (tryAgain == "yes")
          {
            iGuessed = false;
            min = 1.0;
            max = 100.0;
          }
        }
        else if (isItRight == "higher")
        {
          min = guess;
        }
        else if (isItRight == "lower")
        {
          max = guess;
        }
      }
    }
  }
}
