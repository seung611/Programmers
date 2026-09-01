using System;
using System.Text.RegularExpressions;

public class Solution {
    public int[] solution(string my_string)
    {
        string str = Regex.Replace(my_string, @"[^0-9]", "");
        int[] answer = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            answer[i] += int.Parse(str[i].ToString());
        }
        Array.Sort(answer);
        return answer;
    }
}