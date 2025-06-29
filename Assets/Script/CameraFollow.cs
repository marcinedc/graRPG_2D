using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;      // gracz
    public float smoothSpeed = 0.125f;
    public Vector3 offset;        // odleg³oœæ kamery od gracza

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Utrzymanie kamery na tej samej g³êbokoœci Z
        smoothedPosition.z = transform.position.z;

        transform.position = smoothedPosition;
    
    
        
    }
}
