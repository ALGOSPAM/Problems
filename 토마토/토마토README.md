# Problems

#로또
def solution(lottos, win_nums):
    # [0]은 최소, [1]은 최대 
    result = [7,7]
    for i in lottos :
        if i in win_nums :
            result[0] -= 1
            result[1] -= 1
        if i == 0 : 
            result[0] -= 1
    if result[0] == 7:
        result[0] = 6
    if result[1] == 7:
        result[1] = 6
    return result


#비밀번호
class Solution(object):
    def strongPasswordCheckerII(self, password):
        if len(password) < 8 :
            return False
            
        validCnt = [0,0,0,0]
        prevChar = ''
        print(len(password))
        for c in password:
            #인접문자 비교
            if prevChar == c:
                return False
            prevChar = c;
            if c.isupper() :
                validCnt[0] +=1
            elif c.islower():
                validCnt[1] +=1
            elif c.isdigit and not c in '!@#$%^&*()-+' :
                validCnt[2] +=1
            else :
                validCnt[3] +=1
            
        for cnt in validCnt:
            if cnt <= 0 :
                return False
        return True
