```c#
public int solution(int[,] board)
        {
            int ln = board.GetLength(0);
            int count = 0;

            // 모든 위치에 대해 검사
            for (int i = 0; i < ln; i++)
            {
                for (int j = 0; j < ln; j++)
                {
                    if (board[i, j] == 0) // 현재 위치가 지뢰가 아니면
                    {
                        int dangerCount = 0;

                        // 현재 위치 주변 8칸 검사
                        for (int k = i - 1; k <= i + 1; k++)
                        {
                            for (int l = j - 1; l <= j + 1; l++)
                            {
                                if (k >= 0 && k < ln && l >= 0 && l < ln && board[k, l] == 1) // 범위 내에 있으면서 지뢰가 있는 경우
                                {
                                    dangerCount++; // 위험 지역 카운트 증가
                                }
                            }
                        }

                        if (dangerCount == 0) // 주변에 지뢰가 없는 경우
                        {
                            count++; 
                        }
                    }
                }
            }

            return count; 
        }
```
