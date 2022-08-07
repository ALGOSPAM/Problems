https://school.programmers.co.kr/learn/courses/30/lessons/77484
```csharp
using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2] {6, 6};
        var minHitNumCnt = win_nums.Intersect(lottos).Count();        
        var minRank = GetRank(minHitNumCnt);
        
        var zeroNumCnt = zeroNumber(lottos);
        if(zeroNumCnt == 0){
            answer[0] = minRank;
            answer[1] = minRank;
        }else{
            
            answer[0] = GetRank(minHitNumCnt + zeroNumCnt);
            answer[1] = minRank;
        }
        
        return answer;
    }
    
    private int zeroNumber(int[] numbers) => numbers.Count(x=>x == 0);
    
    private int GetRank(int hitNumCnt)
    {
        if(hitNumCnt == 6){
            return 1;
        }
        else if(hitNumCnt == 5){
            return 2;
        }
        else if(hitNumCnt == 4){
            return 3;
        }
        else if(hitNumCnt == 3){
            return 4;
        }
        else if(hitNumCnt == 2){
            return 5;
        }
        
        return 6;
    }
}
```

https://leetcode.com/problems/strong-password-checker-ii/
```csharp
using System.Text.RegularExpressions;
public class Solution
{
        public bool StrongPasswordCheckerII(string password)
        {
                if (password.Length < 8)
                        return false;

                bool isLowerCase = password.ToCharArray().Where(x => ((int)x) >= 97 && ((int)x) <= 122).Count() > 0 ? true : false;

                if (!isLowerCase)
                {
                        return false;
                }
                bool isUpperCase = password.ToCharArray().Where(x => ((int)x) >= 65 && ((int)x) <= 90).Count() > 0 ? true : false;
                if (!isUpperCase)
                {
                        return false;
                }
                bool isNumber = password.ToCharArray().Where(x => ((int)x) >= 48 && ((int)x) <= 57).Count() > 0 ? true : false;
                if (!isNumber)
                {
                        return false;
                }
                bool isSpecialCharacters = Regex.IsMatch(password, @"[^a-zA-Z0-9가-힣]");
                //bool isSpecialCharacters = password.ToCharArray().Where(x => ((int)x) >= 33 && ((int)x) <= 47).Count() > 0 ? true : false;

                if (!isSpecialCharacters)
                {
                        return false;
                }

                char checkChar = password[0];

                for(int i=1;  i<password.Length; i++)
                {
                        if ((int)checkChar != (int)password[i])
                        {
                                checkChar = password[i];                       
                        }
                        else
                        {
                                return false;
                        }
                }

                return true;
        }
}
```
