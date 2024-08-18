using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1f;
    public List<GameObject> waypoints;
    public int currentWaypoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[currentWaypoint].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, waypoints[currentWaypoint].transform.position) < 1.0f)
        {
            currentWaypoint += 1;
        }
        if (currentWaypoint == waypoints.Count)
        {
            currentWaypoint = 0;
        }

        
    }
}
