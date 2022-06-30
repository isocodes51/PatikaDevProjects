using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your  class should be named Solution */
         int n = Convert.ToInt32(Console.ReadLine());
         Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string[] m = name.Split(" ");
                
                phoneBook.Add(m[0], m[1]);
                    
            }
            string searchName= "";
            while ((searchName = Console.ReadLine()) != null) 
            {
                if(phoneBook.ContainsKey(searchName))
                    Console.WriteLine(searchName+"="+phoneBook[searchName]);
                else
                    Console.WriteLine("Not found");
            } 
              
        
   }
}
 
