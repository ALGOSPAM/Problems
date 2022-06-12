https://leetcode.com/problems/baseball-game/
```Python
class Solution(object):
    def calPoints(self, ops):
        """
        :type ops: List[str]
        :rtype: int
        """
        myList = []
        total = 0
        for i in ops:
            if i == 'C':
                myList.pop()
            elif i == 'D':
                myList.append(int(myList[-1])*2)
            elif i == '+':
                myList.append(int(myList[-1])+int(myList[-2]))
            else:
                myList.append(i)
        for i in myList:
            total+= int(i)
        
        return total
```
