https://leetcode.com/problems/k-closest-points-to-origin/
```c++
class Solution {
    
public:
    vector<vector<int>> kClosest(vector<vector<int>>& points, int k) {
        ios_base :: sync_with_stdio(false);
        cin.tie(NULL);
        cout.tie(NULL);
        vector<vector<int>> result;
        
        multimap<double,pair<int,int>> list;
        for(int i = 0; i < points.size(); ++i)
        {
            int x = points[i][0]; int y = points[i][1];
            
            auto temp = ((x-0) * (x-0) + (y - 0) * (y - 0));
            list.insert(make_pair(sqrt(temp), make_pair(x,y)));
        }
        
        for(auto& [key,value] : list)
        {
            if(result.size() >= k)
                break;
            
            vector<int> temp{value.first, value.second};
            result.push_back(temp);
        }
        
        return result;
    }
};
```
