### 36. Valid Sudoku
## https://leetcode.com/problems/valid-sudoku/description/
# java
```java
class Solution {
    public boolean isValidSudoku(char[][] board) {
        
        HashSet<String> set = new HashSet<>();
        
        for(int i = 0; i < 9; i++) {
            for(int j = 0; j < 9; j++) {
                char current = board[i][j];
                if(current != '.') {
                    if(!set.add(current + "found in row" + i) ||
                        !set.add(current + "found in column" + j) ||
                        !set.add(current + "found in sub-box" + i / 3 + "," + j / 3)) {
                        return false;                        
                    }
                }
            }
        }
        return true;
    }
}
```

### 701. Insert into a Binary Search Tree
## https://leetcode.com/problems/insert-into-a-binary-search-tree/
# java
```
class Solution {
    public TreeNode insertIntoBST(TreeNode root, int val) {

        //1. Recursion
        if(root==null) return new TreeNode(val);
        if(root.val > val){
            root.left = insertIntoBST(root.left,val);
        }else{
            root.right = insertIntoBST(root.right,val);
        }
        return root;
    }
}
```
