```js
        function solution(scores) {
            var answer = '';
            for (var i = 0; i < scores.length; i++) {
                var max = 0, min = 100, sum = 0, div = scores.length;
                for (var j = 0; j < scores.length; j++) {
                    if (i != j) {
                        max = Math.max(max, scores[j][i]);
                        min = Math.min(min, scores[j][i]);
                    }
                    sum += scores[j][i];
                }
                if (scores[i][i] < min || scores[i][i] > max) {
                    sum -= scores[i][i];
                    div--;
                }
                var avg = sum / div;
                answer += (avg >= 90 ? "A" : avg >= 80 ? "B" : avg >= 70 ? "C" : avg >= 50 ? "D" : "F");
            }
            return answer;
        }
```
