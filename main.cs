using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    string[] lines = System.IO.File.ReadAllLines(@"input.txt");

    int[] top3 = {0,0,0};
    int runningTotal = 0;
    
    foreach (string calorie in lines){
      if(calorie.Length > 0) {
        runningTotal += Convert.ToInt32(calorie);
      } else {
        if (runningTotal > top3[0]) {
          top3[2] = top3[1];
          top3[1] = top3[0];
          top3[0] = runningTotal;
        } else if (runningTotal > top3[1]) {
          top3[2] = top3[1];
          top3[1] = runningTotal;
        } else if (runningTotal > top3[2]) {
          top3[2] = runningTotal;
        }
        runningTotal = 0;
      }    
    }
    // Keep the console window open in debug mode.
    Console.WriteLine("Total: {0}", top3[0]+top3[1]+top3[2]);
    System.Console.ReadKey();
  }
  
}