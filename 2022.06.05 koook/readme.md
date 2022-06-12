https://leetcode.com/problems/baseball-game/

Baseball game

''' python3

class Solution:
    def calPoints(self, ops: list[str]) -> int:
        answer = 0
        answer_list = []
        for i in range(len(ops)):
            if i!= 0 and ops[i] == "C":
                answer_list.pop()
            elif i!= 0 and ops and ops[i] == "D":
                answer_list.append(answer_list[-1] * 2)
            elif i>1 and ops[i] == "+":
                answer_list.append(answer_list[-1] + answer_list[-2])
            else:
                answer_list.append(int(ops[i]))
        answer = sum(answer_list)
        return answer


'''

https://leetcode.com/problems/powx-n/

pow(x,n)
''' python3

class Solution:
    def myPow(self, x: float, n: int) -> float:
        return x**n
        
'''
