
1910. Remove All Occurrences of a Substring
https://leetcode.com/problems/remove-all-occurrences-of-a-substring/
```csharp
public class Solution {
    public string RemoveOccurrences(string s, string part) {
        string tempS = s;
        int indexOfPart = tempS.IndexOf(part);
        while (indexOfPart >= 0)
        {
            tempS = tempS.Remove(indexOfPart, part.Length);
            indexOfPart = tempS.IndexOf(part);
        }

        return tempS;
    }
}
```
