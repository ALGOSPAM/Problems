// https://programmers.co.kr/learn/courses/30/lessons/42586
// ��ɰ���

using System;
using System.Collections.Generic;

public class Solution
{
    // ���� ���� �� ���� ����� ���� �Ǵ��� ��ȯ
    public int[] solution(int[] progresses, int[] speeds)
    {
        int[] workDays = new int[progresses.Length];

        // �� progresses �� �۾��ϼ��� ����
        for (int i = 0; i < progresses.Length; i++)
        {
            var progress = progresses[i];
            var speed = speeds[i];

            var leftProgress = 100 - progress;

            float calculateDay = (float)leftProgress / speed;

            // ���� �۾��ϼ��� �Ҽ��� �ø�
            var workDay = (int)Math.Ceiling(calculateDay);

            workDays[i] = workDay;
        }

        var count = 0;
        var currentWork = workDays[0]; //ù��° ��� �۾��ϼ�
        var workDayList = new List<int>();

        // �۾� �� ���� ���� ���� ���
        for (int i = 1; i < workDays.Length; i++)
        {
            var nextWork = workDays[i]; //�ι�° ��� ���� �۾��ϼ�

            if (currentWork >= nextWork)
            {
                // ���� �۾��ϼ� ���� ���� �۾��ϼ���� ���� �۾��ϼ� ������ ���Ե�
                count++;
            }
            else
            {
                // ���� �۾��ϼ� ���� ū �۾��ϼ���� ���� �۾��ϼ� ������ ���Ե��� ���� => ���� ó��
                workDayList.Add(count + 1);
                currentWork = workDays[i];
                count = 0;
            }
        }

        workDayList.Add(count + 1); // ������ ���� ó��

        var answer = workDayList.ToArray();

        return answer;
    }
}