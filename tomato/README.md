[Add Two Numbers]
# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    def addTwoNumbers(self, l1, l2):
        """
        1. 리스트에 담긴 노드들을 pop하여 끝 노드부터 변수에 담는다
        2. 이때 해당 노드를 N이라 칭하면 N이 위치한 길이만큼 *10을 통해 저장하고, 다음 노드부터 기존 노드에 값을 더한다.
        3. 두개의 리스트 노드를 합연산한다.
        4. 합연산된 결과를 리스트로 형변환시켜 revese 시킨다.
        """
        NUM1 = []
        NUM2 = []
        while l1 is not None:
            NUM1.append(str(l1.val))
            l1 = l1.next
        while l2 is not None:
            NUM2.append(str(l2.val))
            l2 = l2.next
        NUM1.reverse()
        NUM2.reverse()
        tempStr1 = ''.join(NUM1)
        tempStr2 = ''.join(NUM2)
        CAL = int(tempStr1) + int(tempStr2)
        result = list(map(int,str(CAL)))
        result.reverse()
        #연결 리스트로 변환
        head = ListNode(result[0])
        tail = head
        e = 1
        while e < len(result):
          tail.next = ListNode(result[e])
          
[Maximum Number of Groups Entering a Competition]          
class Solution(object):
    def maximumGroups(self, grades):
        N = len(grades)
        CNT = 0
        TOTAL = 0
        """
        1. 오름차순으로 정렬한다.
        2. N을 1부터 N+1만큼의 그룹으로 나누고 나머지를 저장하는 것을 반복한다.
        3. 더 나뉘지 않으면 그룹이 나뉜 count만큼 return 시킨다.
        """
        if N == 1:
            return 1
        for i in range(1, N+1) :
            TOTAL += i
            if TOTAL <= N:
                CNT+=1
            else :
                return CNT
          tail = tail.next
          e+=1
        return head
        
        
        
