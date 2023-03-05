https://leetcode.com/problems/insert-into-a-binary-search-tree/

``` C#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root is null)
        {
            root = new TreeNode(val);
        }
        else if (root.val < val)
        {
            if (root.right is null)
            {
                root.right = new TreeNode(val);
            }
            else
            {
                InsertIntoBST(root.right, val);
            }
        }
        else
        {
            if (root.left is null)
            {
                root.left = new TreeNode(val);
            }
            else
            {
                InsertIntoBST(root.left, val);
            }
        }
    
        return root;
    }
}
```

https://leetcode.com/problems/valid-sudoku/

``` C#
using System.Collections.Generic;

public class Solution
{
    int n = 9;
    int subBoxesSize = 3;
    char dot = '.';
    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < n; i++)
        {
            // 세로
            if (!IsDuplicated(0, n - 1, i, i, board))
            {
                return false;
            }

            // 가로
            if (!IsDuplicated(i, i, 0, n - 1, board))
            {
                return false;
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                var subBoxStartYIndex = i * subBoxesSize;
                var subBoxStartXIndex = j * subBoxesSize;

                if(!IsDuplicated(subBoxStartXIndex, subBoxStartXIndex + 2, subBoxStartYIndex, subBoxStartYIndex + 2, board))
                {
                    return false;
                }
            }
        }

        return true;
    }

    bool IsDuplicated(int startX, int endX, int startY, int endY, char[][] board)
    {
        var hashSet = new HashSet<char>();
        
        for (int i = startY; i <= endY; i++)
        {
            for (int j = startX; j <= endX; j++)
            {
                var currentChar = board[i][j];
                
                if (currentChar == dot)
                {
                    continue;
                }

                if (hashSet.Contains(currentChar))
                {
                    return false;
                }

                hashSet.Add(currentChar);
            }
        }

        return true;
    }
}
```