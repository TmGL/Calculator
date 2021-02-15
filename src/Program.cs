using System;

namespace Calculator 
{
  class MainClass 
  {
    public static void Main(string[] args) 
    {
      Adding addClass = new Adding();
      Subtracting subClass = new Subtracting();
      Multiplying mulClass = new Multiplying();
      Dividing divClass = new Dividing();

      Console.WriteLine("Hello, I am a calculator! What would you like to do? (Tip: Type 'options' to see all available options).");
      goto choosing;

      start2:
      Console.WriteLine("What would you like to do next? (Tip: Type 'options' to see all available options).");

      choosing:
      string choice = Console.ReadLine().ToLower();

      switch(choice) 
      {
        case "options": 
        case "option":
          Console.WriteLine("Available options: \n\n- add \n- subtract \n- multiply \n- divide \n\nType 'aliases' for a list of aliases!");
          goto choosing;

        case "aliases":
        case "aliase":
          Console.WriteLine("Aliases for each option: \n\n- add: sum, plus, total\n- subtract: minus, sub, take away, difference \n- multiply: mul, times, product, lots of \n- divide: div, share, group");
          goto choosing;

        case "add":
        case "sum":
        case "plus":
        case "total":
          Console.WriteLine("Please type your first number.");
          addStart:

          bool isNumber = int.TryParse(Console.ReadLine(), out int aNum1);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto addStart;
          }

          Console.WriteLine("Please type your second number.");

          addStart2:

          isNumber = int.TryParse(Console.ReadLine(), out int aNum2);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto addStart2;
          }

          Console.WriteLine(aNum1 + " + " + aNum2 + " = " + addClass.addNums(aNum1, aNum2));
          goto start2;

        case "subtract":
        case "sub":
        case "minus":
        case "take away":
        case "difference":
          Console.WriteLine("Please type your first number.");
          subStart:

          isNumber = int.TryParse(Console.ReadLine(), out int sNum1);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto subStart;
          }

          Console.WriteLine("Please type your second number.");
          
          subStart2:

          isNumber = int.TryParse(Console.ReadLine(), out int sNum2);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto subStart2;
          }

          Console.WriteLine(sNum1 + " - " + sNum2 + " = " + subClass.subNums(sNum1, sNum2));
          goto start2;

        case "times":
        case "product":
        case "lots of":
        case "multiply":
        case "mul":
          Console.WriteLine("Please type your first number.");
          mulStart:

          isNumber = int.TryParse(Console.ReadLine(), out int mNum1);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto mulStart;
          }

          Console.WriteLine("Please type your second number.");

          mulStart2:

          isNumber = int.TryParse(Console.ReadLine(), out int mNum2);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto mulStart2;
          }

          Console.WriteLine(mNum1 + " x " + mNum2 + " = " + mulClass.mulNums(mNum1, mNum2));
          goto start2;

        case "divide":
        case "div":
        case "share":
        case "group":
          Console.WriteLine("Please type your first number.");
          divStart:

          isNumber = int.TryParse(Console.ReadLine(), out int dNum1);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto divStart;
          }

          Console.WriteLine("Please type your second number.");

          divStart2:

          isNumber = int.TryParse(Console.ReadLine(), out int dNum2);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto divStart2;
          }

          Console.WriteLine(dNum1 + " ÷ " + dNum2 + " = " + divClass.divNums(dNum1, dNum2));
          goto start2;


        default:
          Console.WriteLine("That is not a valid option! (Tip: Type 'options' to see all available options).");
          goto choosing;
      }
    }
  }
}