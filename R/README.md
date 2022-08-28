2358. Maximum Number of Groups Entering a Competition

https://leetcode.com/problems/maximum-number-of-groups-entering-a-competition/

```Csharp
public class Solution {
    public int MaximumGroups(int[] grades) {
        var orderByGrades = grades.OrderBy(x => x).ToList();
        int cnt =0;
        int lastGroupCnt = 0;
        
        for(int i=0; i<orderByGrades.Count;)
        {
                if (orderByGrades.Count < i + lastGroupCnt + 1)
                        break;
                lastGroupCnt++;
                i = i + lastGroupCnt;
                cnt++;
        }
        return cnt;
    }
}
```
