# 로또의 최고 순위와 최저 순위
# https://school.programmers.co.kr/learn/courses/30/lessons/77484

```python
def solution(lottos, win_nums):
    
    dict = {}
    
    # 맞은 갯수 = 등수
    dict[6] = 1
    dict[5] = 2
    dict[4] = 3
    dict[3] = 4
    dict[2] = 5
    dict[1] = 6
    dict[0] = 6
    
    answer = []
    max = 0
    min = 0
    
    for lotto in lottos:
        
        if lotto == 0:
            max += 1
        elif lotto in win_nums:
            max += 1
            min += 1
    
    answer.append(dict[max])
    answer.append(dict[min])
    
    return answer
```

# 2299. Strong Password Checker II
# https://leetcode.com/problems/strong-password-checker-ii/

```python
class Solution:
    def strongPasswordCheckerII(self, password: str) -> bool:
        isStrongPwd = False
        
        num = 0
        lower = 0
        upper = 0
        schar = 0
        isNear = False
        
        length = len(password)
        
        # 적어도 8문자가 있습니다.
        if length < 8:
            return False
        
        beforeCharCode = 0
        
        for i in range(length):
            
            # 인접한 위치에 동일한 문자가 포함되어 있지 않습니다 
            if beforeCharCode == ord(password[i]):
                return False
            
            if password[i].isdecimal():
                num += 1
            if password[i].isupper():
                upper += 1
            if password[i].islower():
                lower += 1
            if password[i].isalnum() == False:
                schar += 1
        
            beforeCharCode = ord(password[i])
        
        # 적어도 하나의 대문자 가 포함되어 있습니다 .
        if upper < 1:
            return False
        # 적어도 하나의 소문자 가 포함되어 있습니다 .
        if lower < 1:
            return False
        # 적어도 하나의 숫자 가 포함되어 있습니다 .
        if num < 1:
            return False
        # 적어도 하나의 특수 문자 가 포함되어 있습니다 . 
        if schar < 1:
            return False
        
        return True  
```