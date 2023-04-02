https://leetcode.com/problems/binary-tree-pruning/description/

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
    public TreeNode PruneTree(TreeNode root)
    {
        if (root is null)
        {
            return root;
        }
            
        root.left = PruneTree(root.left);
        root.right = PruneTree(root.right);

        if (root.left is not null || root.right is not null)
        {
            return root;
        }

        return root.val == 1 ? root : null;
    }
}
```

https://leetcode.com/problems/merge-intervals/description/

``` C#
public int[][] Merge(int[][] intervals)
{
    intervals = intervals.OrderBy(x => x[0]).ToArray();
    
    var result = new List<int[]>();

    var start = intervals[0][0];
    var end = intervals[0][1];

    for (int i = 1; i < intervals.Length; i++)
    {
        if (intervals[i][0] <= end)
        {
            if (end < intervals[i][1])
            {
                end = intervals[i][1];
            }

            continue;
        }
        else
        {
            result.Add(new int[] { start, end });

            start = intervals[i][0];
            end = intervals[i][1];
        }
    }

    if (result.Count > 0)
    {
        var last = result[result.Count - 1];

        if (last[0] != start || last[1] != end)
        {
            result.Add(new int[] { start, end });
        }
    }
    else
    {
        result.Add(new int[] { start, end });
    }

    return result.ToArray();
}

public int[][] Merge(int[][] intervals) {
    var ordered = intervals.OrderBy(interval => interval[0]).ThenBy(interval => interval[1]);
    var result = new List<int[]>();
    
    result.Add(ordered.Skip(1).Aggregate(ordered.First(), (runningInterval, currentInterval) =>
    {
        var runningEnd = runningInterval[1];
        var currentStart = currentInterval[0];

        if (runningEnd >= currentStart)
        {
            runningInterval[1] = Math.Max(currentInterval[1], runningInterval[1]);
            return runningInterval;
        }
        else
        {
            result.Add(runningInterval);
            return currentInterval;
        }
    }));

    return result.ToArray();
}
```