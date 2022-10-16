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
