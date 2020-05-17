using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOperation : MonoBehaviour
{
    public Transform target;
    Camera camera;

    void Start()
    {
        camera = GetComponent<Camera>();
    }

    void Update()
    {
        Vector3 screenPos = camera.WorldToScreenPoint(target.position);
//        Debug.Log("target is " + screenPos.x + " pixels from the left");
    }
}
