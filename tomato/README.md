[공통문제 Island Perimeter]

[문제 해석]
키 포인트는 그래프에서 한점을 골라 4가지의 방향을 탐색하며 둘레를 구하는데,

이때 둘레를 구하는 방식은 범위 밖에 있거나, 땅이 아니면 둘레를 1을 추가하는 방식으로 전개할 예정입니다.
```
class Solution(object):
    def islandPerimeter(self, grid):
        """
        :type grid: List[List[int]]
        :rtype: int
        """
        def dfs(grid, i, j):
            #만약 현재 위치가 0보다 작거나 범위보다 크면 1을 리턴시켜준다.
            if i < 0 or j < 0 or i >= len(grid) or j >= len(grid[0]):
                return 1
            #현재 위치가 물이라면 return 시켜준다
            print(i,j)
            if grid[i][j] == 0 :
                return 1
            
            #만약 현재 위치가 이미 방문한 위치라면 pass
            if grid[i][j] == -1 :
                return 0

            #방문 처리
            grid[i][j] = -1 

            #나머지 4방향 탐색
            result = 0
            result+=dfs(grid, i-1, j)
            result+=dfs(grid, i+1, j)
            result+=dfs(grid, i, j-1)
            result+=dfs(grid, i, j+1)
            
            return result
        
        result = 0
        for x in range(len(grid)):
            for y in range(len(grid[0])):
                if grid[x][y] == 1:
                    return dfs(grid,x,y)
  ```
    
    
[개인문제 유기농 배추]

[문제 해석]
dfs를 하며 매트릭스를 방문처리 시키고, 방문처리 되지 않은곳을 찾아서 반복시킵니다.
```
import sys

sys.setrecursionlimit(10 ** 6)
T = int(input())


def dfs(x, y, matrix):
    if x < 0 or y < 0:
        return False
    if len(matrix) <= x or len(matrix[0]) <= y:
        return False
    if matrix[x][y] != 1:
        return False

    matrix[x][y] = 0  # 방문처리
    dfs(x + 1, y, matrix)
    dfs(x - 1, y, matrix)
    dfs(x, y + 1, matrix)
    dfs(x, y - 1, matrix)

    return True

for i in range(T):
    M, N, K = list(map(int, input().split()))
    matrix = [[0] * N for _ in range(M)]
    for _ in range(K):
        x, y = map(int, input().split())
        matrix[x][y] = 1
    cnt = 0
    for i in range(M):
        for j in range(N):
            if matrix[i][j] == 1:
                dfs(i, j, matrix)
                cnt += 1
    print(cnt)
```
    
