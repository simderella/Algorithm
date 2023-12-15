public class Solution {
    public long[] solution(long n) 
    {
        long size = n.ToString().Length; //자연수 n의 길이만큼을 숫자형으로 표현
        long[] answer = new long[size]; //long[] 배열의 answer은 size를 원소로 갖는 새로운 길이만큼의 배열로 갖는다.

        for(long i = 0; i < size; i++) 
        {
            answer[i] = n % 10;  //자릿수 더하기 코드+ 배열의 순서를 뒤집기
            n /= 10; //1의 자리부터 n의 자릿수를 늘려간다.
        }
        return answer;
    }
}

/*71589
길이는 5
for문을 돌았을 때,

answer[0] = 9 , 10으로 나눴을 때의 몫 = 7158
answer[1] = 8 , 10으로 나눴을 때의 몫 = 715
answer[2] = 5 , 10으로 나눴을 때의 몫 = 71
answer[3] = 1 , 10으로 나눴을 때의 몫 = 7
answer[4] = 7 , 10으로 나눴을 때의 몫 = 0
*/