using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 difference;

    private void LateUpdate()
    {
        transform.position = difference + target.position;
    }
}
