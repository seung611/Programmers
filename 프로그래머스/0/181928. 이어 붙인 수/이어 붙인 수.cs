using System;

public class Solution {
    public int solution(int[] num_list) {
        string temp = "";
        string temp1 = "";
        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
            {
                temp += num_list[i];
            }
            else
            {
                temp1 += num_list[i];
            }
        }
        int answer = Int32.Parse(temp) + Int32.Parse(temp1);
        return answer;
    }
}