
python3

https://leetcode.com/problems/island-perimeter/

Island Perimeter

'''
class Solution:
    def islandPerimeter(self, grid:list[list[int]])->int:
        grid = self.AddZeroBorder(grid)
        answer = self.PerimeterChecker(grid)
        return answer

    
    #Border에 zero 추가
    def AddZeroBorder(self,Grid: list[list[int]]):
        #가로
        for i in Grid:
            i.insert(0,0)
            i.append(0)
        
        #세로
        tempList = []
        for i in Grid[0]:
            tempList.append(0)
        
        Grid.insert(0, tempList)
        Grid.append(tempList)
        return Grid
        
    
    def PerimeterChecker(self, Grid: list[list[int]]):
        answer = 0
        for i in range(1,len(Grid)-1):
            for j in range(1,len(Grid[0])-1):
                if(Grid[i][j] == 1):
                    if(Grid[i-1][j]==0):
                        answer +=1
                        
                    if(Grid[i+1][j]==0):
                        answer +=1
                        
                    if(Grid[i][j-1]==0):
                        answer +=1
                    
                    if(Grid[i][j+1]==0):
                        answer +=1
                       
        return answer
        
        
'''
