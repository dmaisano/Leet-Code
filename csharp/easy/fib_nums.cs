using System;
using System.Collections.Generic;

public class Solution
{
  static void Main(string[] args)
  {
    List<int> fibNums = new List<int>();

    fibNums.Add(0);
    fibNums.Add(1);

    Console.Write("Enter n-th Fibonacci Number to generate: ");
    int N = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i <= N; i++)
    {
      if (i <= 1) continue;

      int num = fibNums[i - 1] + fibNums[i - 2];
      fibNums.Add(num);
    }

    Console.WriteLine($"'{N}' Fibonacci Number is {fibNums[N]}");
  }
}
