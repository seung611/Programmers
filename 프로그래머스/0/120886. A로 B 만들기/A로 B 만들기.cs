using System;
using System.Linq;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        char[] beforeChars = before.ToCharArray();
        char[] afterChars = after.ToCharArray();
        beforeChars.Sort();
        afterChars.Sort();
        beforeChars.ToString();
        afterChars.ToString();
        bool a = afterChars.SequenceEqual(beforeChars);
        if (a == true)
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
        return answer;
    }
}