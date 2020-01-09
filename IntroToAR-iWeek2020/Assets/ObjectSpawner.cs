using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject spawnObject;
    private ARTapToPlaceObject ARTapToPlaceObject;
    void Start()
    {
        ARTapToPlaceObject = FindObjectOfType<ARTapToPlaceObject>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(spawnObject, ARTapToPlaceObject.transform.position, ARTapToPlaceObject.transform.rotation);
        }
    }
}
