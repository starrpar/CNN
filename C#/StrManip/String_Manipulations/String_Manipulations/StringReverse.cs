using System;
using System.Text;


partial class StringManipulation{
    public string StringReversal(string inputStr){
        var returnStr = new StringBuilder();

        var inputStrLength = inputStr.Length;
        var tempCharArr = new char[inputStrLength];
        var j = inputStrLength-1;

        for(int i = 0; i < inputStrLength; i++){
            //Console.WriteLine("j: " + j + "char[j]: " + inputStr[j]);
            tempCharArr[i] = inputStr[j];
            j--;
        }
        Func<int, string, bool> isLonger = (x, s) => { Console.WriteLine(s.Length + ", " + x);if(s.Length < x){return true;} return false;};
        Console.WriteLine(isLonger);
        for(int i = 0; i < inputStrLength; i++){
            returnStr.Append(tempCharArr[i]);
        }

        return returnStr.ToString();
    }
}