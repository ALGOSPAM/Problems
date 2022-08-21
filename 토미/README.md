# Problems

https://school.programmers.co.kr/learn/courses/30/lessons/67256?language=javascript

``` js
var pad = new Map();
pad.set(1, [0, 0]);
pad.set(2, [0, 1]);
pad.set(3, [0, 2]);
pad.set(4, [1, 0]);
pad.set(5, [1, 1]);
pad.set(6, [1, 2]);
pad.set(7, [2, 0]);
pad.set(8, [2, 1]);
pad.set(9, [2, 2]);
pad.set(0, [3, 1]);

var leftSet = new Set();
leftSet.add(1);
leftSet.add(4);
leftSet.add(7);

var rightSet = new Set();
rightSet.add(3);
rightSet.add(6);
rightSet.add(9);

function solution(numbers, hand) {
    var answer = '';

    var leftThumb = [3, 0];
    var rightThumb = [3, 2];

    numbers.forEach(number => {
        var numberLocation = pad.get(number);

        // 왼손 전용
        if(leftSet.has(number)){
            SetLeft(numberLocation);
            return;
        }

        //오른손 전용
        if(rightSet.has(number)){
            SetRight(numberLocation);
            return;
        }

        
        var leftDistance = getDistance(leftThumb, numberLocation);
        var rightDistance = getDistance(rightThumb, numberLocation);

        // 가까운 손으로 눌러준다
        if (leftDistance > rightDistance){
            SetRight(numberLocation);
        }
        else if(leftDistance < rightDistance){
            SetLeft(numberLocation);
        }
        // 만약 거리가 같다면? 무슨 손잡이인지 확인
        else{
            if(hand == 'left'){
                SetLeft(numberLocation);
            }
            else{
                SetRight(numberLocation);
            }
        }
    });

    console.log(numbers);
    return answer;
    
    function SetLeft(location){
        // stringbuilder를 따로 사용하지 안해도 괜찮다고함????갓 js
        answer += 'L';
        leftThumb = location;
    }

    function SetRight(location){
        answer += 'R';
        rightThumb = location;
    }
}

// Manhattan distance(Euclidean distance로 하면 틀림......)
function getDistance(location1, location2){
    var width = Math.abs(location1[0] - location2[0]);
    var height = Math.abs(location1[1] - location2[1]);

    return width + height;
}

```

https://leetcode.com/problems/restore-ip-addresses/

``` C#

public class Solution {
    
    List<string> result;
    string literal;
    
    public IList<string> RestoreIpAddresses(string s) {
        result = new List<string>();
        literal = s;
        
        var stack = new Stack<string>();
        
        Find(stack, 0);
        
        return result;
    }
    
    void Find(Stack<string> stack, int startIndex)
    {
        if (stack.Count >= 4)
        {
            if (literal.Length == startIndex)
            {
                result.Add(string.Join('.', stack.Reverse()));
            }
            
            return;
        }
        
        var endIndex = startIndex;
        
        while (GetAddressPart(startIndex, endIndex, out var part))
        {
            stack.Push(part);
            Find(stack, endIndex + 1);
            stack.Pop();
            endIndex++;
        }
    }
    
    bool GetAddressPart(int startIndex, int endIndex, out string part)
    {
        part = default;
        
        if (endIndex >= literal.Length)
        {
            return false;
        }
        
        var partSize = endIndex - startIndex + 1;
        
        if (partSize > 1 && literal[startIndex] == '0')
        {
            return false;
        }
        
        var subString = literal.Substring(startIndex, partSize);
        
        if(byte.TryParse(subString, out _)){
            part = subString;
            return true;
        }
        
        return false;
    }
}

```