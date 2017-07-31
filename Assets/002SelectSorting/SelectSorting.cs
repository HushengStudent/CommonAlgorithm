using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class SelectSorting 
{
    /// <summary>
    /// 选择排序;
    /// </summary>
    /// <param name="list">无序List</param>
    /// <returns>从小到大有序List</returns>
    public static List<int> SortingIntSmall(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] > list[j])
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
        return list;
    }
}
