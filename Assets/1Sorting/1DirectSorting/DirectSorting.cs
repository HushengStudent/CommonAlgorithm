using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// 直接插入排序;
/// </summary>
public static class DirectSorting 
{
    //list为已排序list;
    public static List<int> SortingInt(int target, List<int> list)
    {
        List<int> tempList = new List<int>();

        foreach (var temp in list)
        {
            if (temp > target)
            {
                tempList.Add(target);
            }
            tempList.Add(temp);
        }

        return tempList;
    }
}
