using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlight: MonoBehaviour
{
    public Transform targetPoint; // The target point to move the instantiated object to
    public float moveSpeed = 5f; // Speed at which the object moves to the target point
    public string targetTag = "Pumpkin"; // Replace with the tag of the target objects

    private void Start()
    {       
            GameObject nearestObject = FindNearestWithTag(targetTag);
            if (nearestObject != null)
            {
                targetPoint = nearestObject.transform;
                Debug.Log("Nearest Object: " + nearestObject.name + ", Position: " + targetPoint.position);
            }

        GameObject FindNearestWithTag(string tag)
        {
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
            GameObject nearestObject = null;
            float shortestDistance = Mathf.Infinity;
            Vector3 currentPosition = transform.position;

            foreach (GameObject obj in taggedObjects)
            {
                float distance = Vector3.Distance(currentPosition, obj.transform.position);
                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    nearestObject = obj;
                }
            }

            return nearestObject;
        }
    }
void Update()
    {
            // Move the instantiated object towards the target point
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPoint.position,
                moveSpeed * Time.deltaTime
            );
     }

}

