using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointsManager : MonoBehaviour
{
    public static Transform[] wPoints;

    void Awake()
    {
        wPoints = new Transform[transform.childCount];
        for (int i = 0; i < wPoints.Length; i++)
        {
            wPoints[i] = transform.GetChild(i);
        }
    }
}
