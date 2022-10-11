using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    private Vector3 targetPosition;
    private void SetTarget(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }



    private void OrientToTarget()
    {
        Vector3 lookDirection = (targetPosition - transform.position).normalized;
        transform.forward = lookDirection;
    }
    private void Update()
    {
        SetTarget(WorldMouse.GetPosition());
        OrientToTarget();
    }
}
