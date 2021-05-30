스킬트리

```cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string skill, string[] skill_trees) {
            int answer = 0;
            bool chk = true;

            foreach (var str in skill_trees)
            {
                List<char> strList = str.ToCharArray().ToList(); // FindIndex 리스트화

                chk = true;
                for (var i = 0; i < skill.Length - 1; i++) // -1 하는 이유는 배열 오류가 나서
                {
                    int pIndex = strList.FindIndex(x => x.Equals(skill[i])); // 스킬 글자와 맞는 것을 찾는다
                    int nIndex = strList.FindIndex(x => x.Equals(skill[i + 1])); // 하나 더 찾는다 (순서 보려고)

                    if ((pIndex > nIndex && nIndex >= 0) || (pIndex < 0 && nIndex >= 0)) // 이전 스킬이 다음보다 먼저 있으며 다음 스킬이 처음에 있는 경우 || 이전 스킬이 없는데 다음 스킬이 존재
                    {
                        chk = false;
                        break;
                    }
                }
                if (chk)
                {
                    answer++;
                }
            }

            return answer;
    }
}
```
