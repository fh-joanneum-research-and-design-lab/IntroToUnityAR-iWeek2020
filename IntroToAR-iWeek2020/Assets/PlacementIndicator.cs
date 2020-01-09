using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System;

public class PlacementIndicator : MonoBehaviour
{
    private ARRaycastManager arOriginRayCast;
    private GameObject visual;

    void Start()
    {
        visual = transform.GetChild(0).gameObject;
        arOriginRayCast = FindObjectOfType<ARRaycastManager>();
        visual.SetActive(false);
    }

    void Update()
    {
        //shoot raycast from the center of the screen
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        arOriginRayCast.Raycast(screenCenter, hits, TrackableType.Planes);

        //if we hit ar plane
        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;

            if (!visual.activeInHierarchy)
                visual.SetActive(true);
        }
    }

}
