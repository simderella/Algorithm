public class Solution {
    public int solution(int num) {
        int answer = 0;
        long numLong = num;
        for(int i=0; i<500; i++) //500번 반복
        {
            if(numLong == 1)
            {
                return i;
            }
            else if(numLong % 2 == 0) //짝수
            {
                numLong = numLong / 2;
            } 
            else //홀수
            {
                numLong = numLong * 3 + 1;
            }

        }
        return -1;
    }
}