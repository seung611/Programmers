using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[2];
        int _count = 0;
        int count = 0;
        for (int i = 0; i < num_list.Length; i++){
            if (num_list[i] % 2 == 0){
                _count++;
            }
            else{
                count++;
            }
        }
        answer[0] = _count;
        answer[1] = count;
        return answer;
    }
}