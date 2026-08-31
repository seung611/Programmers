using System;

public class Solution {
    public string solution(string my_string) {
        // string answer = "";
        char[] charArr = my_string.ToCharArray();
        Array.Reverse(charArr);
        string newStr = new string(charArr);
        
        return newStr;
    }
}