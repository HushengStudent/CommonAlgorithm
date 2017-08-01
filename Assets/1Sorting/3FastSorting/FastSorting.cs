using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class FastSorting 
{

    //快速排序;
    public static List<int> FastSortingInt(List<int> list)
    {
        if (list.Count == 1) return list;
        int target = list[list.Count/2];

        List<int> leftList = new List<int>();
        List<int> rightList = new List<int>();

        for (int x = 0; x < list.Count; x++)
        {
            if (x == (list.Count / 2)) continue;
            if (list[x] <= target)
            {
                leftList.Add(list[x]);
            }
            else
            {
                rightList.Add(list[x]);
            }
        }

        if (leftList.Count>0) leftList = FastSortingInt(leftList);
        if (rightList.Count > 0) rightList = FastSortingInt(rightList);

        leftList.Add(target);
        leftList.AddRange(rightList);

        return leftList;
    }
}
