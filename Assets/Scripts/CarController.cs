using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField]
    public Transform nextPosition;

    [SerializeField]
    float speed;
    [SerializeField]
    float rotationSpeed;
    [SerializeField]
    float breakSpeed;
    float mySpeed;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mySpeed = speed;

    }

    private void Update()
    {
        Vector3 vector = nextPosition.position - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(vector), rotationSpeed);
        transform.Translate(vector.normalized * Time.deltaTime * speed, Space.World);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            var currentSpeed = other.GetComponent<CarController>().speed;
            speed = Mathf.Lerp(speed, 4, breakSpeed);
            Debug.Log("Hello");
        }
    }
   
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            speed = mySpeed;
        }
    }


}
