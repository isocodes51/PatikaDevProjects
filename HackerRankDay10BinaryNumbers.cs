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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Hesaplama hesaplama = new Hesaplama();
        
        hesaplama.Hesapla(n);        
    }
    
    
}
class Hesaplama{
    public void Hesapla(int myParam){
        int kalan=0;
        int max=0;
        
        while(myParam>0){
            if(myParam%2==1)
              kalan++;
            else
             kalan=0;    
             
            max = Math.Max(kalan, max);  
            myParam/=2;
        }
        Console.Write(max);
        
                     
    }
   
}
