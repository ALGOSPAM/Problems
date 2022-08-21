[카카오 인턴] 키패드 누르기

https://school.programmers.co.kr/learn/courses/30/lessons/67256?language=java
```JAVA
class Solution {
    public String solution(int[] numbers, String hand) {
        String answer = "";
        int lastRightThumb = 10;
        int lastLeftThumb = 12;
        for(int i=0; i<numbers.length; i++)
        {
            int temp = numbers[i];
            if(temp == 0){
                temp = 11;
            }
            
            if(temp % 3 == 0){
                answer += "R";
                lastRightThumb = temp;
                continue;
            }
            else if(temp % 3 == 1){
                answer += "L";
                lastLeftThumb = temp;
                continue;
            }
            // Math.abs(temp-lastLeftThumb) / 3 = 열 이동 수
            // Math.abs(temp-lastLeftThumb) % 3 = 행 이동 수
            int leftDist = Math.abs(temp-lastLeftThumb) / 3 + Math.abs(temp-lastLeftThumb) % 3;
            int rightDist = Math.abs(temp-lastRightThumb) / 3 + Math.abs(temp-lastRightThumb) % 3;
            
            if(leftDist < rightDist){
                answer += "L";
                lastLeftThumb = temp;
            }else if (leftDist > rightDist){
                answer += "R";
                lastRightThumb = temp;
            }else{
                if(hand.equals("left")){
                    answer+="L";
                    lastLeftThumb = temp;
                }else{
                    answer+="R";
                    lastRightThumb = temp;
                }
            }
        }
        
        return answer;
    }
}
```
