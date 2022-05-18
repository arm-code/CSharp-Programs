/*
* THIS FILE MANAGE A DICTIONARY IN C#
* READ DATASET, SAVE INTO DICTIORNARY AND THEN SEARCH SOME RANDOM VALUE NAME.
* THIS PROGRAM WORK WITH 1000 VALUES
*/
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> dic = new Dictionary<string, string>();
        
        for(int i = 0; i < n; i++){
            string value = Console.ReadLine();
            string [] words = value.Split(' ');
                dic.Add(words[0], words[1]);            
        }  
        /*
        *THIS BLOCK CODE ONLY WORK WITH VALUES < 1000, THEN, SHOW A RUNTIME ERROR
        for(int j = 0; j < n; j++){
            string search = Console.ReadLine();            
            if(dic.ContainsKey(search)){                   
                Console.WriteLine(search + "=" + dic[search]);
            }else{
                Console.WriteLine("Not found");
            }
        }
        
        */
        
        /* HERE IT WORK WITH 1000 VALUES, OTHERS IMPLEMETATION DOES NOT WORK */
        String name;        
        while (( name = Console.ReadLine()) != null)
        {
            try
            {
                Console.WriteLine($"{name}={PhoneBook[name]}");
            }
            catch
            {
                Console.WriteLine("Not found");
            }
        }
        
    }
}
