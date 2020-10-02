using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    float smoothSpeed = 0.125f;

    [SerializeField]
    Vector3 offset;

    private Vector3 velocity = Vector3.zero;

    void FixedUpdate() {

        Vector3 targetPosition = target.TransformPoint(offset);

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothSpeed);
    }
    
}
