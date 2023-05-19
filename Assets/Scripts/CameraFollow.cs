using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    private void LateUpdate()
    {
        var newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
        if (target.position.y > transform.position.y)
        {
            transform.position = newPos;
        }
    }
}
