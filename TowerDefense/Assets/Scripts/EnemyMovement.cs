using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    
    private Transform target;
    private int wayPointIndex = 0;

    private void Start()
    {
        target = WayPoints.wayPointsArray[0];
    }
    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    
        if(Vector3.Distance(transform.position, target.position) <= 0.4f) 
        {
            GetNextWayPoint();
        }
    }
    void GetNextWayPoint() 
    {
        if(wayPointIndex >= WayPoints.wayPointsArray.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wayPointIndex++;
        target = WayPoints.wayPointsArray[wayPointIndex];
    }
}
