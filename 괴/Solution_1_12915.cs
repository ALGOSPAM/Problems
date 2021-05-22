// https://programmers.co.kr/learn/courses/30/lessons/12915
// ���ڿ� �� ������� �����ϱ�

using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] strings, int n)
    {
        var lstWord = new List<string>();

        string[] answer = new string[strings.Length];

        // ���� ���ڿ� ���ϱ�
        foreach (var word in strings)
        {
            lstWord.Add(word.Substring(n, 1) + word);
        }

        // ���� ���ڿ� ����
        lstWord.Sort();

        // ���� ���ڿ��� ���� ����� ����
        for (int i = 0; i < lstWord.Count; i++)
        {
            foreach (var word in strings)
            {
                if (lstWord[i].Substring(1) == word)
                {
                    answer[i] = word;

                    break;
                }
            }
        }

        return answer;
    }
}