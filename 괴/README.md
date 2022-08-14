# N-Queen
# https://school.programmers.co.kr/learn/courses/30/lessons/12952

```python

```

# 1910. Remove All Occurrences of a Substring
# https://leetcode.com/problems/remove-all-occurrences-of-a-substring/

```python
class Solution:
    def removeOccurrences(self, s: str, part: str) -> str:
        
        while s.count(part):
            s = s[0:s.index(part) + len(part)].replace(part, '') + s[s.index(part) + len(part):]

        return s
```

# 2022.03.20 Remove All Occurrences of a Substring 문제를 풀어 다른 문제를 풀었습니다.

# 2284. Sender With Largest Word Count
# https://leetcode.com/problems/sender-with-largest-word-count/

```python
class Solution:
    def largestWordCount(self, messages: List[str], senders: List[str]) -> str:
        
        dict = {}
        
        for i in range(len(senders)):
            
            sender = senders[i]
            message = messages[i]
            
            words = message.count(' ') + 1
            
            if sender in dict:
                dict[sender] += words 
            else:
                dict[sender] = words
        
        win = []
        count = 0
        
        for key, value in dict.items():
            
            if count < value:
                win = []
                win.append(key)
                count = value
            elif count == value:
                if ord(win[0][0:1]) < ord(key[0:1]):
                    win = []
                    win.append(key)
                elif ord(win[0][0:1]) == ord(key[0:1]):
                    win.append(key)
        
        if len(win) > 1:
            return sorted(win, reverse = True)[0]
        else:
            return win[0]
```