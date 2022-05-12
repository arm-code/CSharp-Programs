/*
  THIS FILE CONCATENATE STRINGS, BUT ONLY SELECT THE EVENS AND ODDS POSITIONS CHARACTERS, THEN PRINT. 
*/
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = int.Parse(Console.ReadLine());
        
        for(int i = 0; i<T; i++){
            string str_odd ="";
            string str_even="";
            string S = Console.ReadLine();            
            for(int j = 0; j < S.Length; j ++){
                if(j%2 == 0){
                str_even +=S[j];
                }else{
                    str_odd += S[j];
                }
            }
            Console.WriteLine(str_even + " " + str_odd);            
        }
        
        
    }
}
