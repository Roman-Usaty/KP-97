using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransform : MonoBehaviour
{
    public Transform transformObject;
    public int axis;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition[axis] = transformObject.position[axis];
        transform.position = newPosition;
    }
}
