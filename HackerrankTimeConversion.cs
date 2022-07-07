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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
          string[] dizi = s.Split(":");
           decimal hh = Convert.ToInt32(dizi[0]);
            //int mm = Convert.ToInt32(dizi[1]);
            var ss = "";
            var x = "";
            var deger = "";
            if (dizi[2].Contains("AM"))
            {
                ss = dizi[2].Remove(2);
                if (hh == 12 )
                {
                    hh = 0;
                    hh.ToString();
                    x = "0" + hh;
                    deger = string.Format("{0}:{1}:{2}", x, dizi[1], ss);
                }
                else if (hh < 12)
                {
                    deger = string.Format("{0}:{1}:{2}", dizi[0], dizi[1], ss);

                }
            }
            else if (dizi[2].Contains("PM"))
            {
                ss = dizi[2].Remove(2);
                if (hh < 12)
                {
                    hh = hh + 12;
                    hh.ToString();
                    deger = string.Format("{0}:{1}:{2}", hh, dizi[1], ss);
                }
                else
                {
                    
                    //hh.ToString();
                    deger = string.Format("{0}:{1}:{2}", hh, dizi[1], ss);
                }

            }
            
            

          
            return deger;
     
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
