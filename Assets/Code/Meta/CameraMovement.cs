using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    public Vector3 cameraOffset;

    public float cameraSpeed = 0.125f;

    void Start()
    {
        transform.position = player.position + cameraOffset;
    }
    void FixedUpdate ()
    {
        Vector3 finalPosition = player.position + cameraOffset;
        Vector3 lerpPosition = Vector3.Lerp (transform.position, finalPosition, cameraSpeed*Time.deltaTime);
        transform.position = lerpPosition;
    }
    
}
