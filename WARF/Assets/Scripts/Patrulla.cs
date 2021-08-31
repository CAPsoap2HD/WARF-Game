using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrulla : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoint;

    [SerializeField]
    float moveSpeed = 2f;

    int waypointIndex = 0;

    private void Start()
    {
        transform.position = waypoint[waypointIndex].transform.position;
    }
    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoint[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

        if (transform.position == waypoint[waypointIndex].transform.position) { waypointIndex += 1; }

        if (waypointIndex == waypoint.Length)
            waypointIndex = 0;
    }
}
