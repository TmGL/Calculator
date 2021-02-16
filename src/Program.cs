using System;

namespace Calculator 
{
  class MainClass 
  {
    public static void Main(string[] args) 
    {
      Maths math = new Maths();

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
          bool isNumber = decimal.TryParse(Console.ReadLine(), out decimal aNum1);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto addStart;
          }

          Console.WriteLine("Please type your second number.");

          addStart2:
          isNumber = decimal.TryParse(Console.ReadLine(), out decimal aNum2);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto addStart2;
          }

          Console.WriteLine(aNum1 + " + " + aNum2 + " = " + math.addNums(aNum1, aNum2));
          goto start2;

        case "subtract":
        case "sub":
        case "minus":
        case "take away":
        case "difference":
          Console.WriteLine("Please type your first number.");

          subStart:
          isNumber = decimal.TryParse(Console.ReadLine(), out decimal sNum1);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto subStart;
          }

          Console.WriteLine("Please type your second number.");
      
          subStart2:

          isNumber = decimal.TryParse(Console.ReadLine(), out decimal sNum2);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto subStart2;
          }

          Console.WriteLine(sNum1 + " - " + sNum2 + " = " + math.subNums(sNum1, sNum2));
          goto start2;

        case "times":
        case "product":
        case "lots of":
        case "multiply":
        case "mul":
          Console.WriteLine("Please type your first number.");

          mulStart:
          isNumber = decimal.TryParse(Console.ReadLine(), out decimal mNum1);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto mulStart;
          }

          Console.WriteLine("Please type your second number.");

          mulStart2:
          isNumber = decimal.TryParse(Console.ReadLine(), out decimal mNum2);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto mulStart2;
          }

          Console.WriteLine(mNum1 + " x " + mNum2 + " = " + math.mulNums(mNum1, mNum2));
          goto start2;

        case "divide":
        case "div":
        case "share":
        case "group":
          Console.WriteLine("Please type your first number.");
          
          divStart:
          isNumber = decimal.TryParse(Console.ReadLine(), out decimal dNum1);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto divStart;
          }

          Console.WriteLine("Please type your second number.");

          divStart2:

          isNumber = decimal.TryParse(Console.ReadLine(), out decimal dNum2);
          if (!isNumber) {
            Console.WriteLine("Please provide a valid number!");
            goto divStart2;
          }

          Console.WriteLine(dNum1 + " ÷ " + dNum2 + " = " + math.divNums(dNum1, dNum2));
          goto start2;


        default:
          Console.WriteLine("That is not a valid option! (Tip: Type 'options' to see all available options).");
          goto choosing;
      }
    }
  }
}