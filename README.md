# 가장 큰 수 
## javascript

<pre>
<code>
function solution(numbers) {
    var arr = numbers.map(n => n.toString());
    var answer = arr.sort((a,b) => (b+a) - (a+b)).join("");
    answer[0] === "0" ? answer = "0" : answer;
    return answer;
}
</code>
</pre>
