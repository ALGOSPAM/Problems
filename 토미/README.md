https://leetcode.com/problems/island-perimeter/

``` C#

public class Solution {
    public int IslandPerimeter(int[][] grid) {
            var result = 0;

    var queue = new Queue<(int, int)>();
    var ySize = grid.Length;
    var xSize = grid[0].Length;

    (int, int) startingPoint = (0, 0);

    for (int i = 0; i < grid.Length; i++)
    {
        var isSet = false;
        for (int j = 0; j < grid[0].Length; j++)
        {
            if (grid[i][j] == 1)
            {
                startingPoint = (i, j);
                isSet = true;
                break;
            }
        }

        if (isSet)
        {
            break;
        }
    }

    queue.Enqueue((startingPoint.Item1, startingPoint.Item2));

    while (queue.TryDequeue(out var point))
    {
        if (grid[point.Item1][point.Item2] == 2)
        {
            continue;
        }

        grid[point.Item1][point.Item2] = 2;

        var adjacentLandCount = 0;

        var leftPoint = (point.Item1, point.Item2 - 1);
        var rightPoint = (point.Item1, point.Item2 + 1);
        var topPoint = (point.Item1 - 1, point.Item2);
        var bottomPoint = (point.Item1 + 1, point.Item2);

        if (leftPoint.Item2 >= 0 &&
            grid[leftPoint.Item1][leftPoint.Item2] != 0)
        {
            adjacentLandCount++;
            if (grid[leftPoint.Item1][leftPoint.Item2] == 1)
            {
                queue.Enqueue(leftPoint);
            }
        }

        if (rightPoint.Item2 < xSize &&
            grid[rightPoint.Item1][rightPoint.Item2] != 0)
        {
            adjacentLandCount++;
            if (grid[rightPoint.Item1][rightPoint.Item2] == 1)
            {
                queue.Enqueue(rightPoint);
            }
        }

        if (topPoint.Item1 >= 0 &&
            grid[topPoint.Item1][topPoint.Item2] != 0)
        {
            adjacentLandCount++;
            if (grid[topPoint.Item1][topPoint.Item2] == 1)
            {
                queue.Enqueue(topPoint);
            }
        }

        if (bottomPoint.Item1 < ySize &&
            grid[bottomPoint.Item1][bottomPoint.Item2] != 0)
        {
            adjacentLandCount++;
            if (grid[bottomPoint.Item1][bottomPoint.Item2] == 1)
            {
                queue.Enqueue(bottomPoint);
            }
        }

        result += 4 - adjacentLandCount;
    }

    return result;
    }
}
```

https://leetcode.com/problems/design-circular-queue/

``` C#
public class MyCircularQueue {
    int[] data;
    int startIndex = 0;
    int inputCount = 0;

    public MyCircularQueue(int k)
    {
        data = new int[k];
    }

    public bool EnQueue(int value)
    {
        if (inputCount >= data.Length)
        {
            return false;
        }

        data[(startIndex + inputCount) % data.Length] = value;
        inputCount++;

        return true;
    }

    public bool DeQueue()
    {
        if (inputCount < 1)
        {
            return false;
        }

        inputCount--;

        startIndex = ++startIndex % data.Length;

        return true;
    }

    public int Front()
    {
        if (inputCount < 1)
        {
            return -1;
        }

        return data[startIndex];
    }

    public int Rear()
    {
        if (inputCount < 1)
        {
            return -1;
        }

        return data[(startIndex + inputCount - 1) % data.Length];
    }

    public bool IsEmpty()
    {
        return inputCount == 0;
    }

    public bool IsFull()
    {
        return inputCount == data.Length;
    }
}
```