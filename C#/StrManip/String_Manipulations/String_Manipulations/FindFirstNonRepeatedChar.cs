using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

partial class StringManipulation{

    public string FirstNonRepeatingChar(string s){
        Console.WriteLine(s);
        
        var ret_val = "";

        //calculate number of occurrences of each character in input string
        var char_dict = new Dictionary<char, int>();
        int j = 0;
        for(int i = 0; i < s.Length; i++){
            if(char_dict.ContainsKey(s[i])){
                if(s[i] != '\t' && s[i] != ' '){
                    char_dict[s[i]] += 1;
                    //Console.WriteLine("s[i]: " + s[i] + ", num: " + char_dict[s[i]]);
                    //Console.WriteLine("i,j: " + i + ", " + j);
                    j++;
                }
                else{
                    //Console.WriteLine("not incrementing: " + j + ", s[i]: " + s[i]);
                }
            }
            else
            {
                if(s[i] != '\t' && s[i] != ' '){
                    char_dict[s[i]] = 1;
                    Console.WriteLine(s[i] + " first found at: " + j);
                    j++;
                }
                else{
                    //Console.WriteLine("not incrementing: " + j + ", s[i]: " + s[i]);
                }
            }
        }

        //sort existing dictionary into a new dictionary
        var sorted_dict = from entry in char_dict orderby entry.Value descending select entry;
        int sort_dict_len = char_dict.Count;

/*
        //...and print out for quick visibility/debugging
        foreach(var entry in sorted_dict){
            Console.WriteLine(entry);
        }
*/
        //determine what the first occurring character is (in string order) that does not repeat (i.e. has an occurrence of '1')
        //this approach makes the assumption that the "first occurring" character in the now sorted dictionary for occurrences
        //that indicate only 1 occurrence of said character in the passed-in string will be the first character having been
        //encountered in the original string (and hence entered into the original unsorted dictionary first).  If this is not
        //a valid assumption, additional handling could be added here to ensure the first occurring was identified based on analysis
        //of the original string for all characters that occur only once in the given string, but that is overkill if this assumption
        //is valid.
        var single_occurrence_dict = from entry in sorted_dict where entry.Value == 1 select entry;
        foreach(var entry in single_occurrence_dict){
            ret_val = entry.Key.ToString();
            break;
        }
        
        return ret_val;
    }


    /*
    ret_val = ''
    char_dict = {}
    index_at_which_initially_found = 0
    for c in lc_str:
        #if c != '\t' and c != ' ':
            if c not in char_dict:
                char_dict[c] = [1, index_at_which_initially_found]
            else:
                char_dict[c][0] = char_dict[c][0] + 1
            index_at_which_initially_found += 1
    char_dict = sorted(char_dict.items(), key=lambda item: item[1])
    earliest_index = len(s) + 1
    index_of_earliest_non_repeat_char = 0
    index_through_non_repeat_chars = 0
    for c in char_dict:
        if c[1][0] == 1:#== 1 => single occurrence chars
            if c[1][1] < earliest_index:
                earliest_index = c[1][1]
                index_of_earliest_non_repeat_char = index_through_non_repeat_chars
            else:
                index_through_non_repeat_chars += 1
    
    ret_val += char_dict[index_of_earliest_non_repeat_char][0]
    return ret_val
    */
}

/*

similar output to python program results:
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
" first found at: 94
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
? first found at: 486\
*/