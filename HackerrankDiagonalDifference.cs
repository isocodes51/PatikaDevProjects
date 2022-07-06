using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr, int n)
    { 
    //  var sum=0;
    //  for(int i=0; i<n;i++){
    //      for(int j=0; j<n;j++){
    //          if(i==j){
    //              sum+=arr[i][j];
    //          }
    //         if(i+j == n-1){
    //             sum-=arr[i][j];
    //         }
    //      }
    //  }
    //  return Math.Abs(sum);
    int topSol=0;
    int topSag=0;
    for(int i=0; i<n;i++){
        for(int j=0;j<n;j++){
            if(i==j){
                topSol+=arr[i][j];
               // topSag+=arr[i][j];
            }
            if(i+j==n-1){
                topSag+=arr[i][j];
            }
        }
    }
    return Math.Abs(topSag-topSol);
    //return topSag;
    }     
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr,n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
