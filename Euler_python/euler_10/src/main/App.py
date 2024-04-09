import datetime as dt

# Problem statement:
# The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
# Find the sum of all the primes below two million.

#looking for a value: 142913828922

#create a method that handles the overall - call the adjoining function to find all primes
#then sums those returned (list?) in order to find the sume (answer)
def main(limit):
    #limit = 2000000
    primes = []
    start_time = dt.datetime.now
    sum = 0

    primes = find_all_primes_below(limit)
    for prime in primes:
        sum += prime
    end_time = dt.datetime.now
    print("sum: ",sum,", amount of time spent: ",end_time-start_time)
    return sum


#create a function that finds all primes below a specified number

def find_all_primes_below(limit_value):
    primes = []
    divisible = False
    for i in range(2,limit_value):
        divisible = False
        for j in range(2,i):
            # print("i,j:",i,j)
            if i%50000 == 0:
                if j%50000 == 0:
                     print("i,j:",i," :: ",j," time:",dt.datetime.now)
            if i % j == 0:
                divisible = True
                continue
        if not divisible:  
            primes.append(i)
            divisible = False
            continue
    return primes

limit = 2000000
#limit = 20000
print("sum of primes below: ", limit, " is: ", main(limit))