using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPoint : MonoBehaviour
{
    [SerializeField]
    List<Transform> nextPoint;

    [SerializeField]
    List<Transform> pedestrianNextPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car")) other.GetComponent<CarController>().nextPosition = nextPoint[Random.Range(0, nextPoint.Count)];
        if (other.CompareTag("Pedestrian"))
        {
            other.GetComponent<pedestrianCurrentWayPoint>().SetNewDestination(pedestrianNextPoint[Random.Range(0, pedestrianNextPoint.Count)]);
        }
    }
}
