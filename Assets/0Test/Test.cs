using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        List<int> temp = new List<int>() { 4, 6, 3, 4, 2, 6, 9, 1, 3, 5, 7, 5, 4, 6, 3, 6, 5, 3, 4, 5, 66, 7, 8, 44, 55, 2, 0, 33, 2, 56 };
        temp = FastSorting.FastSortingInt(temp);
        for (int i = 0; i < temp.Count; i++)
        {
            Debug.LogError(temp[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
