using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pedestrianCurrentWayPoint : MonoBehaviour
{
    NavMeshAgent navMesh;
    public Transform currentWayPoint;
    // Start is called before the first frame update
    void Start()
    {
        navMesh =
        GetComponent<NavMeshAgent>();
        navMesh.SetDestination(currentWayPoint.position);
    }

    // Update is called once per frame
    public void SetNewDestination(Transform currentPoint)
    {
        currentWayPoint = currentPoint;
        navMesh.SetDestination(currentWayPoint.position);

    }
}
