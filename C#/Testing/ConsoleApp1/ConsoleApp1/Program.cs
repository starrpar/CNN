using System;
using System.Collections.Generic;

internal class InheritAbstract: AbClass, ITest{

}

internal class InheritAbstract2: AbClass, ITest, ITest2{

}

internal class InheritInterface: ITest{

}


internal class Utilities{
    internal void PrintInputStrings(List<string> cmdLineArgStrings){
        foreach(string s in cmdLineArgStrings){
            Console.WriteLine("\n" + s);
        }
    }

    internal int NumberOfWords(List<string> cmdLineArgStrings){
        var wordsInString = new Dictionary<string, int>();
        var sentences = new List<string>();
        var words = new List<string>();

        sentences = cmdLineArgStrings.ToList<string>();
        foreach(string s in sentences){
            Console.WriteLine(s);
            //words = s.Split(" ");
        }
        foreach(string s in words){
            Console.WriteLine(s);
        }

        return words.Count;
    }
}

public interface ITest{
    public void method1(){
    
    }

    public string method2(){
        Console.WriteLine("this is method2");
        return "this is method2";
    }
}

public abstract class AbClass{

    public void methodA1(){
    }

    public string methodA2(){
        Console.WriteLine("this is methodA2");
        return "this is methodA2";
    }
}

public interface ITest2{

    public void methodA1(){
    }

    public string methodA2(){
        Console.WriteLine("this is methodA2");
        return "this is methodA2";
    }
}

public class MainClass{

    static List<string> cmdLineArgStrings = new List<string>();
    public static void Main(string[] args){
        if(args.Length > 1){
            foreach(string s in args){
                cmdLineArgStrings.Add(s);
            }
        }

        Utilities utilities = new Utilities();
        utilities.PrintInputStrings(cmdLineArgStrings);
        utilities.NumberOfWords(cmdLineArgStrings);
    }
}
