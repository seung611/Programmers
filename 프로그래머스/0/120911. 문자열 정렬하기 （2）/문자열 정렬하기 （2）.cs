using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        my_string = my_string.ToLower();
        char[] chars = my_string.ToCharArray();
        Array.Sort(chars); 
        answer = new string(chars);
        return answer;
    }
}