using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMouse : MonoBehaviour
{
    private static WorldMouse instance;
    [SerializeField] private LayerMask mousePlaneLayerMask;

    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        transform.position = WorldMouse.GetPosition();
    }

    public static Vector3 GetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, instance.mousePlaneLayerMask);
        return raycastHit.point;
    }
}
