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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
         double toplamPoz,toplamNeg,toplamNotr;
            int sayacPoz = 0, sayacNeg=0,sayacNotr=0;
            for(int i=0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                    sayacPoz++;
                else if (arr[i] < 0)
                    sayacNeg++;
                else
                    sayacNotr++;
            }
            toplamPoz = (double)sayacPoz / arr.Count;
            toplamNeg = (double)sayacNeg / arr.Count;
            toplamNotr = (double)sayacNotr / arr.Count;
           
            Console.WriteLine(toplamPoz.ToString("0.#0000"));
            Console.WriteLine(toplamNeg.ToString("0.#0000"));
            Console.WriteLine(toplamNotr.ToString("0.#0000"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
