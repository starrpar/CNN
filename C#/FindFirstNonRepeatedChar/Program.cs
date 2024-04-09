using System;
using System.Collections.Generic;

class StrManip{
    static public void Main(String[] args)
    {
        string s = "the faint red box shelters a fox that dances in the woods at night under the bright starry lights.";
        //string s = "4.	You have several large binary objects ranging between 100MBs - 200MBs each. Every 5 minutes these objects are 'automagically' uploaded to a storage location hosted by your favorite cloud provider (See mock illustration below). Their paths (excluding root containers) represent the date time in which they were uploaded (e.g., 2021/01/01/04/30 == 2021-01-01 04:30UTC). Your job is to parse these objects/files as quickly as they show up and have the parsed output inserted into a SQL database to support a 'near real-time application'. What service(s) would you use and why?";
        string firstNonRepeatChar = findFirstNonRepeatedChar(s);
        Console.WriteLine(firstNonRepeatChar);
    }

    static public string findFirstNonRepeatedChar(string s){
        string ret_val = "";
        Dictionary<char, List<int>> charDict = new();
        int index_at_which_initially_found = 0;
        foreach(char c in s){
            //if(c != '\t' && c != ' '){
                if(!charDict.ContainsKey(c)){
                    //Dictionary<int, int> tempDict = new()
                    List<int> tempList = new()
                    {
                        1,
                        index_at_which_initially_found
                    };
                    charDict[c] = tempList;
                }
                else if(charDict[c][0] > 0){
                    charDict[c][0]++;
                }
                index_at_which_initially_found++;
            //}
        }

        var sortedDictionary = charDict.OrderBy(x => x.Value[0]).ToDictionary(x => x.Key, x => x.Value);
        foreach(char c in sortedDictionary.Keys){
            sortedDictionary[c].Add(charDict[c][1]);
        }
        
        List<char> keyList = new List<char>(sortedDictionary.Keys);

        ret_val = keyList[0].ToString();
        return ret_val;
    }
}
/*
output for comparison with Python version...
t first found at: 0
h first found at: 1
e first found at: 2
  first found at: 3
f first found at: 4
a first found at: 5
i first found at: 6
n first found at: 7
r first found at: 10
d first found at: 12
b first found at: 14
o first found at: 15
x first found at: 16
s first found at: 18
l first found at: 21
c first found at: 41
w first found at: 52
g first found at: 63
u first found at: 67
y first found at: 89
. first found at: 97
sortedDictionary: c :: 1 :: 41
sortedDictionary: w :: 1 :: 52
sortedDictionary: u :: 1 :: 67
sortedDictionary: y :: 1 :: 89
sortedDictionary: . :: 1 :: 97
sortedDictionary: f :: 2 :: 4
sortedDictionary: b :: 2 :: 14
sortedDictionary: x :: 2 :: 16
sortedDictionary: l :: 2 :: 21
sortedDictionary: g :: 3 :: 63
sortedDictionary: d :: 4 :: 12
sortedDictionary: o :: 4 :: 15
sortedDictionary: i :: 5 :: 6
sortedDictionary: n :: 5 :: 7
sortedDictionary: a :: 6 :: 5
sortedDictionary: r :: 6 :: 10
sortedDictionary: s :: 6 :: 18
sortedDictionary: h :: 8 :: 1
sortedDictionary: e :: 8 :: 2
sortedDictionary: t :: 12 :: 0
sortedDictionary:   :: 18 :: 3
*/
/*
...and...
4 first found at: 0
. first found at: 1
Y first found at: 2
o first found at: 3
u first found at: 4
h first found at: 5
a first found at: 6
v first found at: 7
e first found at: 8
s first found at: 9
r first found at: 13
l first found at: 15
g first found at: 19
b first found at: 21
i first found at: 22
n first found at: 23
y first found at: 26
j first found at: 29
c first found at: 31
t first found at: 32
w first found at: 44
1 first found at: 48
0 first found at: 49
M first found at: 51
B first found at: 52
- first found at: 54
2 first found at: 55
E first found at: 66
5 first found at: 71
m first found at: 72
' first found at: 94
p first found at: 110
d first found at: 114
f first found at: 147
( first found at: 168
S first found at: 169
k first found at: 175
) first found at: 193
T first found at: 195
x first found at: 207
, first found at: 278
/ first found at: 283
3 first found at: 293
= first found at: 295
: first found at: 309
U first found at: 312
C first found at: 314
q first found at: 353
Q first found at: 408
L first found at: 409
W first found at: 455
? first found at: 486
sortedDictionary: E :: 1 :: 66
sortedDictionary: 5 :: 1 :: 71
sortedDictionary: x :: 1 :: 207
sortedDictionary: , :: 1 :: 278
sortedDictionary: : :: 1 :: 309
sortedDictionary: U :: 1 :: 312
sortedDictionary: C :: 1 :: 314
sortedDictionary: q :: 1 :: 353
sortedDictionary: Q :: 1 :: 408
sortedDictionary: L :: 1 :: 409
sortedDictionary: W :: 1 :: 455
sortedDictionary: ? :: 1 :: 486
sortedDictionary: Y :: 2 :: 2
sortedDictionary: M :: 2 :: 51
sortedDictionary: B :: 2 :: 52
sortedDictionary: f :: 2 :: 147
sortedDictionary: S :: 2 :: 169
sortedDictionary: k :: 2 :: 175
sortedDictionary: T :: 2 :: 195
sortedDictionary: 3 :: 2 :: 293
sortedDictionary: = :: 2 :: 295
sortedDictionary: 4 :: 3 :: 0
sortedDictionary: j :: 4 :: 29
sortedDictionary: - :: 4 :: 54
sortedDictionary: ' :: 4 :: 94
sortedDictionary: ( :: 4 :: 168
sortedDictionary: ) :: 4 :: 193
sortedDictionary: 2 :: 5 :: 55
sortedDictionary: m :: 5 :: 72
sortedDictionary: / :: 5 :: 283
sortedDictionary: . :: 7 :: 1
sortedDictionary: v :: 7 :: 7
sortedDictionary: g :: 7 :: 19
sortedDictionary: w :: 7 :: 44
sortedDictionary: 1 :: 7 :: 48
sortedDictionary: b :: 9 :: 21
sortedDictionary: y :: 10 :: 26
sortedDictionary: p :: 13 :: 110
sortedDictionary: c :: 14 :: 31
sortedDictionary: 0 :: 14 :: 49
sortedDictionary: d :: 15 :: 114
sortedDictionary: h :: 17 :: 5
sortedDictionary: l :: 17 :: 15
sortedDictionary: u :: 18 :: 4
sortedDictionary: n :: 18 :: 23
sortedDictionary: i :: 24 :: 22
sortedDictionary: r :: 26 :: 13
sortedDictionary: s :: 28 :: 9
sortedDictionary: o :: 33 :: 3
sortedDictionary: t :: 36 :: 32
sortedDictionary: a :: 37 :: 6
sortedDictionary: e :: 55 :: 8
E
*/