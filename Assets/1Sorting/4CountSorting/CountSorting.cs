using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// 计数排序;
/// </summary>
public static class CountSorting
{

    public static List<int> CountSortingInt(List<int> list)
    {
        //票箱;
        List<int> tempList = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (list[i] > list[j])
                {
                    while (tempList.Count < i + 1)
                    {
                        tempList.Add(0);
                    }
                    tempList[i]++;
                }
            }
        }

        List<int> targetList = new List<int>();

        for (int x = 0; x < tempList.Count; x++)
        {
            while (targetList.Count < tempList[x]+1)
            {
                targetList.Add(0);
            }
            targetList[tempList[x]] = list[x];
        }

        return targetList;
    }
}
