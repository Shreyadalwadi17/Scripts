using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallex : MonoBehaviour
{

    public Transform cameraTransform;
    public float parallaxEffectMultiplier;
    private float lastCameraX;

    private void Start()
    {
        if (cameraTransform == null && Camera.main != null)
            cameraTransform = Camera.main.transform;

        lastCameraX = cameraTransform.position.x;
    }

    private void Update()
    {
        float deltaMovement = cameraTransform.position.x - lastCameraX;
        transform.position += new Vector3(deltaMovement * parallaxEffectMultiplier, 0);
        lastCameraX = cameraTransform.position.x;
    }
}


