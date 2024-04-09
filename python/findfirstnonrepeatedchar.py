""" Write a method that returns the first non-repeated character in the following string ‘s’:
“the faint red box shelters a fox that dances in the woods at night under the bright starry lights.”
You may use an IDE to code your solution, paste the code into the “Answer” section below.
Space constraints: none
Time constraints: O(n)
Your method’s signature will accept 1 argument, “s”, of type string and return a value of type string.
Answer: """

#Rule: no nested loops

def findFirstNonRepeatedChar(s):
    ret_val = ''
    char_dict = {}
    index_at_which_initially_found = 0
    for c in s:
        if c != '\t' and c != ' ':
            if c not in char_dict:
                char_dict[c] = [1, index_at_which_initially_found]
            else:
                char_dict[c][0] = char_dict[c][0] + 1
            index_at_which_initially_found += 1
    sorted_dict = sorted(char_dict.items(), key=lambda item: item[1])
    
    earliest_index = len(s) + 1
    index_of_earliest_non_repeat_char = 0
    index_through_non_repeat_chars = 0
    for c in sorted_dict:
        if c[1][0] == 1:#== 1 => single occurrence chars
            if c[1][1] < earliest_index:
                earliest_index = c[1][1]
                index_of_earliest_non_repeat_char = index_through_non_repeat_chars
            else:
                index_through_non_repeat_chars += 1
    
    ret_val += sorted_dict[index_of_earliest_non_repeat_char][0]
    return ret_val

#s = 'the faint red box shelters a fox that dances in the woods at night under the bright starry lights.'
s = '4.	You have several large binary objects ranging between 100MBs - 200MBs each. Every 5 minutes these objects are "automagically" uploaded to a storage location hosted by your favorite cloud provider (See mock illustration below). Their paths (excluding root containers) represent the date time in which they were uploaded (e.g., 2021/01/01/04/30 == 2021-01-01 04:30UTC). Your job is to parse these objects/files as quickly as they show up and have the parsed output inserted into a SQL database to support a "near real-time application". What service(s) would you use and why?'

solution = findFirstNonRepeatedChar(s)
print('first non-repeated char: ', solution, ' type: ', type(solution))
#print('earliest non-repeated character: ', sorted_str_list[index_of_earliest_non_repeat_char][0], ' at index: ', sorted_str_list[index_of_earliest_non_repeat_char][1][1], ' original string length: ', len(string))

"""
output for cxomparison with C# version...
t  first found at:  0
h  first found at:  1
e  first found at:  2
   first found at:  3
f  first found at:  4
a  first found at:  5
i  first found at:  6
n  first found at:  7
r  first found at:  10
d  first found at:  12
b  first found at:  14
o  first found at:  15
x  first found at:  16
s  first found at:  18
l  first found at:  21
c  first found at:  41
w  first found at:  52
g  first found at:  63
u  first found at:  67
y  first found at:  89
.  first found at:  97
('c', [1, 41])
('w', [1, 52])
('u', [1, 67])
('y', [1, 89])
('.', [1, 97])
('f', [2, 4])
('b', [2, 14])
('x', [2, 16])
('l', [2, 21])
('g', [3, 63])
('d', [4, 12])
('o', [4, 15])
('i', [5, 6])
('n', [5, 7])
('a', [6, 5])
('r', [6, 10])
('s', [6, 18])
('h', [8, 1])
('e', [8, 2])
('t', [12, 0])
(' ', [18, 3])
"""
"""
...and...
4  first found at:  0
.  first found at:  1
Y  first found at:  2
o  first found at:  3
u  first found at:  4
h  first found at:  5
a  first found at:  6
v  first found at:  7
e  first found at:  8
s  first found at:  9
r  first found at:  13
l  first found at:  15
g  first found at:  19
b  first found at:  21
i  first found at:  22
n  first found at:  23
y  first found at:  26
j  first found at:  29
c  first found at:  31
t  first found at:  32
w  first found at:  44
1  first found at:  48
0  first found at:  49
M  first found at:  51
B  first found at:  52
-  first found at:  54
2  first found at:  55
E  first found at:  66
5  first found at:  71
m  first found at:  72
"  first found at:  94
p  first found at:  110
d  first found at:  114
f  first found at:  147
(  first found at:  168
S  first found at:  169
k  first found at:  175
)  first found at:  193
T  first found at:  195
x  first found at:  207
,  first found at:  278
/  first found at:  283
3  first found at:  293
=  first found at:  295
:  first found at:  309
U  first found at:  312
C  first found at:  314
q  first found at:  353
Q  first found at:  408
L  first found at:  409
W  first found at:  455
?  first found at:  486
('E', [1, 66])
('5', [1, 71])
('x', [1, 207])
(',', [1, 278])
(':', [1, 309])
('U', [1, 312])
('C', [1, 314])
('q', [1, 353])
('Q', [1, 408])
('L', [1, 409])
('W', [1, 455])
('?', [1, 486])
('Y', [2, 2])
('M', [2, 51])
('B', [2, 52])
('f', [2, 147])
('S', [2, 169])
('k', [2, 175])
('T', [2, 195])
('3', [2, 293])
('=', [2, 295])
('4', [3, 0])
('j', [4, 29])
('-', [4, 54])
('"', [4, 94])
('(', [4, 168])
(')', [4, 193])
('2', [5, 55])
('m', [5, 72])
('/', [5, 283])
('.', [7, 1])
('v', [7, 7])
('g', [7, 19])
('w', [7, 44])
('1', [7, 48])
('b', [9, 21])
('y', [10, 26])
('p', [13, 110])
('c', [14, 31])
('0', [14, 49])
('d', [15, 114])
('h', [17, 5])
('l', [17, 15])
('u', [18, 4])
('n', [18, 23])
('i', [24, 22])
('r', [26, 13])
('s', [28, 9])
('o', [33, 3])
('t', [36, 32])
('a', [37, 6])
('e', [55, 8])
first non-repeated char:  E  type:  <class 'str'>
"""