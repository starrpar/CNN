
partial class StringManipulation{
     public static string findFirstNonRepeatedChar(string s)
    {
        string ret_val = "";
        Dictionary<char, List<int>> charDict = new();
        int index_at_which_initially_found = 0;

        foreach (char c in s)
        {
            //if(c != '\t' && c != ' '){
            if (!charDict.ContainsKey(c)){
                //Dictionary<int, int> tempDict = new()
                List<int> tempList = new()
                {
                    1,
                    index_at_which_initially_found

                };
                charDict[c] = tempList;
            }
            else if (charDict[c][0] > 0){
                charDict[c][0]++;
            }
            index_at_which_initially_found++;
            //}
        }

        var sortedDictionary = charDict.OrderBy(x => x.Value[0]).ToDictionary(x => x.Key, x => x.Value);
        foreach (char c in sortedDictionary.Keys)
        {
            sortedDictionary[c].Add(charDict[c][1]);
        }
        List<char> keyList = new List<char>(sortedDictionary.Keys);
        ret_val = keyList[0].ToString();

        return ret_val;
    }
}