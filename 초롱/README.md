# 384. Shuffle an Array
## https://leetcode.com/problems/shuffle-an-array/description/
```java
class Solution {
    int[] nums;
    Random random;
    public Solution(int[] nums) {
        this.nums = nums;
        random = new Random();
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] reset() {
        return nums;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] shuffle() {
        int[] rand = new int[nums.length];
        for (int i = 0; i < nums.length; ++i) {
            int j = random.nextInt(i + 1);
            rand[i] = rand[j];
            rand[j] = nums[i];
        }
        return rand;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.reset();
 * int[] param_2 = obj.shuffle();
 */
```

# 814. Binary Tree Pruning
## https://leetcode.com/problems/binary-tree-pruning/description/

### Soluetion type 1) Divide and conquer
```java
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public TreeNode pruneTree(TreeNode root) {
        if(root == null) return root;
        TreeNode left = pruneTree(root.left);
        root.left = left;
        TreeNode right = pruneTree(root.right);
        root.right = right;
        if(root.val == 0 && root.left == null && root.right == null)
            root = null;
        return root;
    }
}
```

### Soluetion type 2) Recursion
```java
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public TreeNode pruneTree(TreeNode root) {
        if(root == null) return root;
        boolean left = true, right = true;
        
        if(root.left != null){
            left = pruneNode(root.left);
            if(left) root.left = null;
        }
        if(root.right != null){
            right = pruneNode(root.right);
            if(right) root.right = null;
        }
        if(left && right && root.val == 0){
            root = null;
        }
        return root;
    }

    private boolean pruneNode(TreeNode node){
        if(node.val == 0 && node.left == null && node.right == null) return true;
        else{
            boolean left = true, right = true;
            if(node.left != null){
                left = pruneNode(node.left);
                if(left) node.left = null;
            }
            if(node.right != null){
                right = pruneNode(node.right);
                if(right) node.right = null;
            }
            return (left && right) && node.val == 0;
        }
    }
}
```
