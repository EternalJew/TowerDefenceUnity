using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public static Transform[] wayPointsArray;
    void Awake ()
    {
        wayPointsArray = new Transform[transform.childCount];
        for (int i = 0; i < wayPointsArray.Length; i++)
        {
           wayPointsArray[i] = transform.GetChild(i);
        }
    }
}
