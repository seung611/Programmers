using System;
using System.Text.RegularExpressions;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        string pattern = "a|e|i|o|u";
        answer = Regex.Replace(my_string, pattern, "");
        return answer;
    }
}