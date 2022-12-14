using UnityEngine;

public class Ennemy : MonoBehaviour
{

    public float speed = 10f;
    private Transform target;
    private int waypointIndex = 0;

    void Start()
    {
        target = Waypoints.points[0];
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized *speed* Time.deltaTime, Space.World); 

        if(Vector3.Distance(transform.position, target.position) <= 0.2f)
            {
            GetNextWaypoint();
            }
    }

    private void GetNextWaypoint()
    {
        if(waypointIndex >= Waypoints.points.Length - 1)
        {
            Endpath();
            return;
        }

        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }

    private void Endpath()
    {
        PlayerStats.lives--;
        Destroy(gameObject);
    }

}

