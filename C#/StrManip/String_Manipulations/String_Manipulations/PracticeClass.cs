class PracticeClass{

    internal static List<int> FindPrimesBelow(int limit){
        var primes = new List<int>();
        var divisible = false;

        //find primes and add them to a list
        for(int i = 2; i <= limit; i++){
            for(int j = 2; j < i; j++){
                if(i%j == 0){
                    //Console.WriteLine(i + " found to be divisible by " + j);
                    divisible = true;
                    break;
                }
            }
            if(divisible){
                divisible = false;
                continue;
            }
            else{
                //Console.WriteLine("adding " + i + " to primes list");
                primes.Add(i);
            }
        }
        return primes;
    }
}

/*
156 found to be divisible by 2
adding 157 to primes list
158 found to be divisible by 2
159 found to be divisible by 3
160 found to be divisible by 2
161 found to be divisible by 7
162 found to be divisible by 2
adding 163 to primes list
164 found to be divisible by 2
165 found to be divisible by 3
166 found to be divisible by 2
adding 167 to primes list
168 found to be divisible by 2
169 found to be divisible by 13
170 found to be divisible by 2
171 found to be divisible by 3
172 found to be divisible by 2
adding 173 to primes list
174 found to be divisible by 2
175 found to be divisible by 5
176 found to be divisible by 2
177 found to be divisible by 3
178 found to be divisible by 2
adding 179 to primes list
180 found to be divisible by 2
adding 181 to primes list
182 found to be divisible by 2
183 found to be divisible by 3
184 found to be divisible by 2
185 found to be divisible by 5
186 found to be divisible by 2
187 found to be divisible by 11
188 found to be divisible by 2
189 found to be divisible by 3
190 found to be divisible by 2
adding 191 to primes list
192 found to be divisible by 2
adding 193 to primes list
194 found to be divisible by 2
195 found to be divisible by 3
196 found to be divisible by 2
adding 197 to primes list
198 found to be divisible by 2
adding 199 to primes list
200 found to be divisible by 2
*/