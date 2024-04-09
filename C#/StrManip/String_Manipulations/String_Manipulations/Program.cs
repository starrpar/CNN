
using System.Reflection.Metadata;

public class Program{
    public static void Main(string[] args){
        //string testStr = "the faint red box shelters a fox that dances in the woods at night under the bright starry lights.";
        //string testStr = "4.	You have several large binary objects ranging between 100MBs - 200MBs each. Every 5 minutes these objects are \"automagically\" uploaded to a storage location hosted by your favorite cloud provider (See mock illustration below). Their paths (excluding root containers) represent the date time in which they were uploaded (e.g., 2021/01/01/04/30 == 2021-01-01 04:30UTC). Your job is to parse these objects/files as quickly as they show up and have the parsed output inserted into a SQL database to support a \"near real-time application\". What service(s) would you use and why?";

        //StringManipulation stringManipulation = new StringManipulation();
        
        //string firstNonRepeatedChar = stringManipulation.FirstNonRepeatingChar(testStr);
        //Console.WriteLine(firstNonRepeatedChar);

        //************************************************************
        //string testString = "this is a test string.";
        //string testString = "So, then... what about this?  Will this work as a test string, or not? ---";

        //string returnedString = stringManipulation.StringReversal(testString);
        // Console.WriteLine(testString + " : " + returnedString);

        //************************************************************
        // stringManipulation.WordReversal(testString);

        //call primes method from here for now for convenience...

        /*
        long limit = 2000000;
        Euler10 euler10 = new Euler10();
        var primesBelowLimit = euler10.CalculatePrimesBelowSpecifiedLimit(limit);
        //foreach(int i in primesBelowLimit){
        //    Console.WriteLine("\n" + i);
        //}
        Console.WriteLine(euler10.SumList(primesBelowLimit));
        */

        var testStr2 = "Yes. The Connected Apps management permission is needed. This permission is on Super Admin and Security Admin role. You can also create a custom role and add this permission to it, along with any other permissions to tailor it to your needs.";
        //Console.WriteLine("Number of words with multiple vowels: " + NewStringManipulation.CountWordsWithAtLeastTwoVowels(testStr2));

        //NewStringManipulation.PracticeLambda(testStr2);

        //var sortedString = NewStringManipulation.ArrangeWordsInOrderedList(testStr2);
        //Console.WriteLine(sortedString.ToString());
        
        //var sortedString2 = NewStringManipulation.ArrangeWordsInSortedDictionary(testStr2);
        //Console.WriteLine(sortedString2.ToString());

        //var sortedString3 = NewStringManipulation.CountWordsWithAtLeastTwoVowels(testStr2);
        //Console.WriteLine(sortedString3.ToString());

        var limit = 200;
        var primes = PracticeClass.FindPrimesBelow(limit);
        Console.WriteLine("primes: ");
        foreach(var entry in primes){
            Console.WriteLine(entry);
        }
    }
}
