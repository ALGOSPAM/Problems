폭탄 구현하기
https://level.goorm.io/exam/158413/%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98%EB%A8%BC%EB%8D%B0%EC%9D%B4-2%ED%9A%8C/quiz/4
```cpp
#include <bits/stdc++.h>

using namespace std;

int main() 
{
	int n;
	cin >> n;
	int k;
	cin >> k;
	
	vector<vector<int>> list(n+2, vector<int>(n+2,0));
	
	for(int i = 0; i < k; ++i)
	{
		int a; int b;
		cin >> a; 
		cin >> b;
		
		list[a][b] += 1;
		
		if(a + 1 < n+1)
			list[a+1][b] += 1;
		if(a - 1 > 0)
			list[a-1][b] += 1;
		if(b + 1 < n+1)
			list[a][b+1] += 1;
		if(b - 1 > 0)
			list[a][b-1] += 1;
	}
	
	int size = 0;
	for(int i = 0; i < list.size(); ++i)
	{
		for(int j = 0; j < list[i].size(); ++j)
			size += list[i][j];
	}
	
	cout << size << endl;
	
	return 0;
}
```
출석부
https://level.goorm.io/exam/158413/%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98%EB%A8%BC%EB%8D%B0%EC%9D%B4-2%ED%9A%8C/quiz/3
```cpp
#include <bits/stdc++.h>

using namespace std;
int main() 
{
	int n;
	cin >> n;
	int k;
	cin >> k;
	map<string, vector<float>> list;
	
	for(int i = 0; i < n; ++i)
	{
		string name;
		cin >> name;
		float height;
		cin >> height;
		
		list[name].push_back(height);
	}
	int count = 0;
	for(auto temp : list)
	{
		vector<float> heights = temp.second;
		sort(heights.begin(), heights.end());
		
		for(int i = 0; i < heights.size(); ++i, ++count)
		{
			if(count == k-1){
				cout << temp.first << " " << fixed << setprecision(2) << heights[i] << " " << endl;
				return 0;
			}
		}
	}
	
	return 0;
}
```

합격자 찾기
https://level.goorm.io/exam/158413/%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98%EB%A8%BC%EB%8D%B0%EC%9D%B4-2%ED%9A%8C/quiz/1
```cpp
#include <bits/stdc++.h>

using namespace std;

vector<string> split(string str, string token){
    vector<string>result;
    while(str.size()){
        int index = str.find(token);
        if(index!=string::npos){
            result.push_back(str.substr(0,index));
            str = str.substr(index+token.size());
            if(str.size()==0)result.push_back(str);
        }else{
            result.push_back(str);
            str = "";
        }
    }
    return result;
}

float average(std::vector<int> const& v){
    if(v.empty()){
        return 0;
    }

    auto const count = static_cast<float>(v.size());
    return std::reduce(v.begin(), v.end()) / count;
}

int main() {
	
	int t;
	cin >> t;
	
	for(int i = 0; i < t; ++i)
	{
		int n; cin >> n;
		vector<int> list;
		for(int j = 0; j < n; ++j)
		{
			int temp;
			cin >> temp;
			list.push_back(temp);
		}
		
		float size = average(list);
		int count = 0;
		
		for(int j = 0; j < list.size(); ++j)
		{
			if(list[j] >= size)
				count += 1;
		}
		
		if(list.size() == 1)
			cout << "1/1" << endl;
		else
			cout << count << "/" << list.size() << endl;
	}
	
	return 0;
}
```

철자 분리 집합
https://level.goorm.io/exam/158413/%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98%EB%A8%BC%EB%8D%B0%EC%9D%B4-2%ED%9A%8C/quiz/2
```cpp
#include <bits/stdc++.h>

using namespace std;
int main() 
{
	int n;
	cin >> n;
	string str;
	cin >> str;
	int count = 0;
	for(int i = 0; i < str.size(); ++i)
	{
		if(str[i] != str[i+1])
			count += 1;
	}
	
	cout << count << endl;
	
	return 0;
}
```
