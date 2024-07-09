using UnityEngine;

public class InstantiateAndMove : MonoBehaviour
{
    public GameObject objectPrefab; // The prefab to instantiate

    public GameObject instantiatedObject;

    void Start()
    {
        instantiatedObject = Instantiate(objectPrefab, transform.position, transform.rotation);
    }

}
