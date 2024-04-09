
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class NewStringManipulation{

    internal static Dictionary<string, int> CountWordsWithAtLeastTwoVowels(string s){
        var unsortedWordDict = new Dictionary<string, int>();
        var sortedWordDict = new Dictionary<string, int>();
        char[] vowels = {'a','e','i','o','u'};

        //put words into a List
        var wordList = s.Split(" ");
        foreach(var entry in wordList){
            if(!unsortedWordDict.Keys.Contains(entry)){
                foreach (var ch in entry){
                    var lchar = char.ToLower(ch);
                    if(vowels.Contains(lchar)){
                        if(!unsortedWordDict.Keys.Contains(entry)){
                            Console.WriteLine("initial entry: " + entry);
                            unsortedWordDict[entry] = 1; //initial entry
                        }
                        else{
                            Console.WriteLine("subsequent entry: " + entry);
                            unsortedWordDict[entry]++;
                        }
                    }
                }
            }
        }

        Console.WriteLine("\nBefore (length = " + unsortedWordDict.Count + "):\n");
        foreach(var entry in unsortedWordDict){
            Console.WriteLine(entry);
        }

        //sort dictionary based on value (into KVP)
        var sortedWordKVP = from entry in unsortedWordDict orderby entry.Value descending select entry;

        Console.WriteLine("\nAfter:\n");
        foreach(var entry in sortedWordKVP){
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }

        return sortedWordDict;
    }

    internal static Dictionary<string, int> ArrangeWordsInSortedDictionary(string s){
        var unsortedWordDict = new Dictionary<string, int>();
        var sortedWordDict = new Dictionary<string, int>();

        //put words into a List
        var wordList = s.Split(" ");
        foreach(var entry in wordList){
            if(!unsortedWordDict.Keys.Contains(entry)){
                Console.WriteLine("initial entry: " + entry);
                unsortedWordDict[entry] = 1; //initial entry
            }
            else{
                Console.WriteLine("subsequent entry: " + entry);
                unsortedWordDict[entry]++;
            }
        }
        Console.WriteLine("\nBefore (length = " + unsortedWordDict.Count + "):\n");
        foreach(var entry in unsortedWordDict){
            Console.WriteLine(entry);
        }

        //sort dictionary based on value (into KVP)
        var sortedWordKVP = from entry in unsortedWordDict orderby entry.Value descending select entry;

        Console.WriteLine("\nAfter:\n");
        foreach(var entry in sortedWordKVP){
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }

        return sortedWordDict;
    }

    internal static List<string> ArrangeWordsInOrderedList(string s){
        var sortedWordList = new List<string>();

        //put words into a List
        var wordList = s.Split(" ");
        foreach(var entry in wordList){
            sortedWordList.Add(entry);
        }
        Console.WriteLine("\nBefore (length = " + sortedWordList.Count + "):\n");
        foreach(var entry in sortedWordList){
            Console.WriteLine(entry);
        }
        sortedWordList.Sort();
        Console.WriteLine("\nAfter (length = " + sortedWordList.Count + "):\n");
        foreach(var entry in sortedWordList){
            Console.WriteLine(entry);
        }

        return sortedWordList;
    }

    internal static void PracticeLambda(string s){
        var strLen = s.Length;
        
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(5));

        //the following denotes a "tree data structure for a lambda expression"
        //as opposed to simply a pointer to a method, as is the case with Func<int, int>
        Expression<Func<int, int>> e = x => x * x;
        Console.WriteLine(e);

        int[] numbers = { 2, 3, 4, 5 };
        var squaredNumbers = numbers.Select(x => x * x);
        Console.WriteLine(string.Join(" ", squaredNumbers));

        Func<int, int> print2X = x => { return x + x;};
        Console.WriteLine(print2X(5));

        Func<int, string, bool> isLonger = (x, s) => { if(s.Length < x){return true;} return false;};
        Console.WriteLine(isLonger(2000,s));


    }
    
}