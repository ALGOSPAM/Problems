

1. 영어 끝말잇기

https://school.programmers.co.kr/learn/courses/30/lessons/12981

python3


'''

    def solution(n, words):
        answer = []
        checklist = []
        checklist.append(words[0])
        check = 0
        flag = -1

        for word in words[1:]:
            check +=1
            if word in checklist:
                flag = -1
                break
            elif word[0] == checklist[-1][-1]:
                checklist.append(word)
                flag = 0
            else:
                flag = -1
                break

        if(flag == 0):
            answer = [0,0]
        else:
            answer = [check%n+1, check//n + 1]

        return answer
'''    
    
 
 2. K Closest Points to Origin
 
    https://leetcode.com/problems/k-closest-points-to-origin/
    
    python3


'''    

        class Solution:
            def kClosest(self, points: list[list[int]], k: int) -> list[list[int]]:
                answer = []

                #거리값 구하기
                DistanceList = []
                for i in points:
                    DistanceList.append([i, i[0]**2 + i[1]**2])

                DistanceList.sort(key = lambda x : x[1])

                for i in range(k):
                    answer.append(DistanceList[i][0])



                return answer
'''
