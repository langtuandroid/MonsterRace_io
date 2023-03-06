using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugRoad : MonoBehaviour
{
    public Rigidbody objectToTrack;
    public float angle;
    public float previousAngle = 0f;

    void Update()
    {
        Vector3 objectVelocity = objectToTrack.velocity;
        angle = Vector3.SignedAngle(transform.forward, objectVelocity, Vector3.up);
        if (angle != previousAngle)
        {
            if (angle > 0)
            {
                Debug.Log("Object is moving clockwise.");
            }
            else
            {
                Debug.Log("Object is moving counterclockwise.");
            }
            previousAngle = angle;
        }
    }
}
