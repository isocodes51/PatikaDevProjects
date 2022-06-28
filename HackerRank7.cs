using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int t = Convert.ToInt32(Console.ReadLine());
            

            for (int b = 0; b < t; b++)
            {
                
                string s = Console.ReadLine().ToString();
                string[] arr = { s };
                foreach (string ss in arr)
                {
                    for (int ix = 0; ix < ss.Length; ix++)
                    {
                        if (ix % 2 == 0)
                        {
                            Console.Write(ss[ix]);
                        }
                    }
                    Console.Write(" ");
                    for (int j = 0; j < ss.Length; j++)
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write(ss[j]);
                        }
                    }

                    Console.WriteLine(" ");
                }
            }
        
    }
}
