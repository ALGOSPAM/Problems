/* 기능 개발 */

using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> answer = new List<int>();
        int[] day = new int[progresses.Length];
        int count = 0;

        for (var i = 0; i < progresses.Length; i++)
        {
            day[i] = (100 - progresses[i]) / speeds[i];

            if ((day[i] * speeds[i]) < (100 - progresses[i]))
            {
                day[i]++;
            }
        }
        int tmp = day[0];
        for (var j = 0; j < day.Length; j++)
        {
            if (tmp >= day[j])
            {
                count++;
                continue;
            }
            else
            {
                answer.Add(count);
                tmp = day[j];
                count = 1;
            }
        }
        answer.Add(count);
        
        return answer.ToArray();
    }
}



/* 내 마음대로 문자열 정렬하기 */
using System.Linq;


public class Solution 
{
    public string[] solution(string[] strings, int n) {
        string[] answer = strings.OrderBy(word => word).ToArray(); // 사전순 정렬
        answer = answer.OrderBy(word => word[n]).ToArray(); // n번째 글자로 정렬

        return answer;
    }
}

/*
참고 문서
https://qzqz.tistory.com/207
https://docs.microsoft.com/ko-kr/dotnet/api/system.linq.enumerable.orderby?view=net-5.0
https://ibocon.tistory.com/100
https://mongyang.tistory.com/108
*/
