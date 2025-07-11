using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;      // gracz
    public float smoothSpeed = 0.125f;
    public Vector3 offset;        // odległość kamery od gracza

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Utrzymanie kamery na tej samej głębokości Z
        smoothedPosition.z = transform.position.z;

        transform.position = smoothedPosition;
    
    
        
    }
}
