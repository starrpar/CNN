using System;
using System.Collections.Generic;

partial class StringManipulation{

    public string WordReversal(string s){

        var lInputStr = s.Split(' ');
        foreach(var word in lInputStr){
            Console.WriteLine("\n" + word);
        }
        var lReversedStr = lInputStr.Reverse<string>();
        foreach(var word in lReversedStr){
            Console.WriteLine("\n" + word);
        }
        return s;
    }
} 