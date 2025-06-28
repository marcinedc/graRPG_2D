 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFix : MonoBehaviour
{

    public float pixelsPerUnit = 16f;

    void LateUpdate()
    {
        Vector3 pos = transform.position;
        float unitsPerPixel = 1f / pixelsPerUnit;

        float roundedX = Mathf.Round(pos.x / unitsPerPixel) * unitsPerPixel;
        float roundedY = Mathf.Round(pos.y / unitsPerPixel) * unitsPerPixel;

        transform.position = new Vector3(roundedX, roundedY, pos.z);
    }

}
