using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    string[] lines = System.IO.File.ReadAllLines(@"input.txt");
    
    List<int> calories = new List<int>();

    foreach (string line in lines){
      if(line.Length > 0) {
        calories.Add(Int32.Parse(line));
      } else {
        calories.Add(-1);
      }
    }
    calories.Add(-1);
    
    int[] caloriesArr = calories.ToArray();

    int calories1 = 0;
    int calories2 = 0;
    int calories3 = 0;
    int runningTotal = 0;
    foreach (int calorie in caloriesArr) {
      if (calorie == -1){
        Console.WriteLine("==========");
        Console.WriteLine("Running total is {0}", runningTotal);
        Console.WriteLine("{0}, {1}, {2}", calories1, calories2, calories3);
        if (runningTotal > calories1) {
          calories3 = calories2;
          calories2 = calories1;
          calories1 = runningTotal;
        } else if (runningTotal > calories2) {
          calories3 = calories2;
          calories2 = runningTotal;
        } else if (runningTotal > calories3) {
          calories3 = runningTotal;
        }
        Console.WriteLine("{0}, {1}, {2}", calories1, calories2, calories3);
        runningTotal = 0;
      }else {
          runningTotal += calorie;
      }
    }
    
    Console.WriteLine("Top 3: {0}, {1}, {2}", calories1, calories2, calories3);
    Console.WriteLine("The total is: {0}", calories1+calories2+calories3);
    
    





    
    // Keep the console window open in debug mode.
    Console.WriteLine("Press any key to exit.");
    System.Console.ReadKey();
  }
}