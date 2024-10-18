using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeV : MonoBehaviour
{
    public float speed; 
    Vector3 startPosition;

    public Vector3 cubedir;

    void Awake()
    {
        startPosition = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "manager")
        {
            transform.position = startPosition;
        }
    }

    void Update()
    {
        transform.Translate(cubedir * speed * Time.deltaTime, Space.World);
    }
}
