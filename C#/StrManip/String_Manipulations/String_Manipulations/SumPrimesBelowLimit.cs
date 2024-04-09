using System;
using System.Reflection.Metadata.Ecma335;

/*
 * Problem statement:
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 * Find the sum of all the primes below two million.
 */
public class Euler10{

    public List<int> CalculatePrimesBelowSpecifiedLimit(long limit){

        var listOfPrimes = new List<int>();

        //listOfPrimes.Add(1);

        for(int i = 2; i < limit; i++){
            if(i%100000 == 0){
                Console.WriteLine("progress...i: "+i);
            }
            //Console.WriteLine("calling DetermineIfPrime(), i = " + i);
            if(DetermineIfPrime(i, limit)){
                //Console.WriteLine("adding next prime:" + nextPrime);
                listOfPrimes.Add(i);
            }
        }
        //Console.WriteLine(listOfPrimes.ToString());
        return listOfPrimes;
    }

    public bool DetermineIfPrime(int number, long limit){
        var divisible = false;

        //Console.WriteLine("in CalculateNextPrime, current = " + number);
        //current is a prime if only divisible by itself and 1
        for(int i = number - 1; i > 1; i--){
            divisible = false;
            //if(i%j == 0){
            if(number%i == 0){
                divisible = true;
                //Console.WriteLine("divisible (number by i), skipping... number: " + number + ", i:" + i);
                break;
            }
        }
            
        if(!divisible){
            return true;
        }

        return false;
    }

    public int SumList(List<int> numberList){
    var sum = 0;
    foreach(int i in numberList){
        sum += i;
    }
    return sum;
}
}




/*
public class mainClass{

    public static void Main(string[] args){
        int limit = 2000000;
        var primesBelowLimit = CalculatePrimesBelowSpecifiedLimit(limit);
        Console.WriteLine(SumList(primesBelowLimit));
    }
}*/