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

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        
        // int row=0;
        // int column=0;
        // int sum=0;
        // for(int i=0;i<4;i++){
        //  for(int j=0;j<3;j++){
        //      if(i!=0 || j!=0){
        //         row+=arr[i][0];
        //         column+=arr[0][j];
        //         sum=row+column;
        //      }
        //  }   
        // }
        
        // Console.WriteLine(sum);
        int maxsum=-64;  
        int hoursum;   
        for(int i=0;i<4;i++){
         for(int j=0;j<4;j++){
           hoursum=arr[i+1][j+1];    
           for(int k=0;k<3;k++){                   
            hoursum = hoursum + arr[i][j+k] + arr[i+2][j+k]; 
           }             
           if(hoursum > maxsum)         
           maxsum = hoursum;       
         }      
        }
        Console.WriteLine(maxsum);
    }
    
}
