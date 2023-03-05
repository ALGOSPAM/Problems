https://school.programmers.co.kr/learn/courses/30/lessons/120866

``` C#
using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] board) {
        var width = board.GetLength(0);
        var height = board.GetLength(1);
        
        var maxXIndex = width - 1;
        var maxYIndex = height - 1;
        
        var safetyZones = new HashSet<(int, int)>();
        
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                safetyZones.Add((i, j));
            }
        }

        for (int i = 0; i <= maxXIndex; i++)
        {
            for (int j = 0; j <= maxYIndex; j++)
            {
                if (board[i, j] == 1)
                {
                    var startX = Math.Max(0, i - 1);
                    var startY = Math.Max(0, j - 1);
                    
                    var endX = Math.Min(maxXIndex, i + 1);
                    var endY = Math.Min(maxYIndex, j + 1);
                    
                    for (int xIndex = startX; xIndex <= endX; xIndex++)
                    {
                        for (int yIndex = startY; yIndex <= endY; yIndex++)
                        {
                            safetyZones.Remove((xIndex, yIndex));
                        }
                    }
                }
            }
        }
        
        return safetyZones.Count;
    }
}
```

https://leetcode.com/problems/deepest-leaves-sum/

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
public class Solution {

    Dictionary<int, int> dictionary = new Dictionary<int, int>();

    public int DeepestLeavesSum(TreeNode root) 
    {
        Travel(root, 0);
        return dictionary.Last().Value;
    }

    void Travel(TreeNode root, int depth)
    {
        if (root == null)
        {
            return;
        }

        if (!dictionary.ContainsKey(depth))
        {
            dictionary.Add(depth, 0);
        }

        dictionary[depth] += root.val;
        Travel(root.left, depth + 1);
        Travel(root.right, depth + 1);
    }
}
```