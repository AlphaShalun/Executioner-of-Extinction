using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform pm;
    private Vector3 deltaPos;

    private void Start()
    {
        deltaPos = transform.position - pm.position;
    }

    private void Update()
    {
        transform.position = pm.position + deltaPos;
    }
}
