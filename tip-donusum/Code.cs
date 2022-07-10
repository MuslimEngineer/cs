
// www.patika.dev
// https://www.hackerrank.com/challenges/30-operators/problem
//https://app.patika.dev/courses/csharp-101/5-operatorler

using System;
using System.Collections.Generic;
using System.IO;
class Solution {

    static int solveMeFirst(int a, int b) { 
      // Hint: Type return a+b; below  
      return a+b;
    }

    static void Main(String[] args) {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1,val2);
        Console.WriteLine(sum);
    }
}      
