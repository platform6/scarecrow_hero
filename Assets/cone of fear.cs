using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeOfFear : MonoBehaviour
{
    public Transform newPosition; // New position to move the object to

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("colllidersslsl");
        // Alter the position, rotation, and scale of the entering object
        other.transform.position = newPosition.position;

    }
}
