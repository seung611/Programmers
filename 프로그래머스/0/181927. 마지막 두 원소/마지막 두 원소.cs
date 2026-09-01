using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
        int num = 0;
        if (num_list[num_list.Length - 1] > num_list[num_list.Length - 2]){
            num = num_list[num_list.Length - 1] - num_list[num_list.Length - 2];
        }
        else{
            num = num_list[num_list.Length - 1] * 2;
        }
        answer = num_list.Concat(new int[] { num }).ToArray();
        return answer;
    }
}