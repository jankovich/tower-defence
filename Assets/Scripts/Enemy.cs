using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform target;
    private int wPointId = 0;

    public float speed = 10f;
    public float wPointTargetingGap = 0.1f;

    void Start()
    {
        target = WaypointsManager.wPoints[0];
    }

    void Update()
    {
        EnemyMove();
        CheckFinalDestination();
    }

    void EnemyMove()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= wPointTargetingGap)
        {
            NextWPoint();
        }
    }

    void NextWPoint()
    {
        wPointId++;
        target = WaypointsManager.wPoints[wPointId];
    }

    void CheckFinalDestination()
    {
        if (wPointId > WaypointsManager.wPoints.Length)
        {
            Destroy(gameObject);
        }
    }
}
