using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject spawnObject;
    private PlacementIndicator placementIndicator;
    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(spawnObject, placementIndicator.transform.position, placementIndicator.transform.rotation);
        }
    }
}
