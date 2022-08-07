'''
python3

#롯또 최고순위

def solution(lottos, win_nums):
    answer = []
    #input data가 lottos, win_nums가 들어오는데, lottos에 0으로 들어오는 게 다 틀린 경우와 다 맞은 경우를 output로 내면 됨.
    
    iNumberOfZero = lottos.count(0) # 0개수 확인
    iNumberOfCouract = 0
    for i in lottos:
        if (i in win_nums):
            iNumberOfCouract += 1
            
    #맞춘 개수에 따라 6등 6등 5등 4등 3등 2등 1등이므로 아래와 같은 list 생성
    lGrad = [6, 6, 5, 4, 3, 2, 1]
    answer = [lGrad[iNumberOfCouract + iNumberOfZero], lGrad[iNumberOfCouract]]
    
    return answer
    
    
#Strong Password Checker 2
class Solution:
    def strongPasswordCheckerII(self, password: str) -> bool:
        pw_LengthCheck = 0;
        pw_LowerCheck = 0;
        pw_UpperCheck = 0;
        pw_DigitCheck=0;
        pw_SpecialCheck = 0;
        pw_SameCharChek = 0;
        tempChar =''
        
        special_list = ['!', '@', '#', '$', '%', '^', '&', '*', '(', ')' ,'-' ,'+']
        
        for check in password:
            if(ord(check) >= 97 and ord(check)<=122):
                pw_LowerCheck = 1;
            if(ord(check) >= 65 and ord(check) <= 90):
                pw_UpperCheck = 1;
            if(ord(check)>=48 and ord(check)<=57):
                pw_DigitCheck = 1;
            if(check in special_list):
                pw_SpecialCheck =1;
            if(check == tempChar):
                pw_SameCharChek = -1;
                break
            elif(check != tempChar):
                tempChar = check;
                pw_SameCharChek = 1;
            
        if(len(password)>=8):
            pw_LengthCheck = 1;
        answer = False
        if(pw_LengthCheck==1 and pw_LowerCheck==1 and pw_UpperCheck ==1 and pw_DigitCheck==1 and pw_SpecialCheck==1 and pw_SameCharChek==1):
            answer = True
        return answer
'''
