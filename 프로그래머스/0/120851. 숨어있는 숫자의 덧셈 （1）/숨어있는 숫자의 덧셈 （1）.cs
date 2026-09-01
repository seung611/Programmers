using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string str = Regex.Replace(my_string, @"\D", "");
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '1')
            {
                answer += 1;
            }
            else if (str[i] == '2')
            {
                answer += 2;
            }
            else if (str[i] == '3')
            {
                answer += 3;
            }
            else if (str[i] == '4')
            {
                answer += 4;
            }
            else if (str[i] == '5')
            {
                answer += 5;
            }
            else if (str[i] == '6')
            {
                answer += 6;
            }
            else if (str[i] == '7')
            {
                answer += 7;
            }
            else if (str[i] == '8')
            {
                answer += 8;
            }
            else if (str[i] == '9')
            {
                answer += 9;
            }
        }
        
        return answer;
    }
}