using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLimiter : MonoBehaviour
{
    public GameObject craneGo;

    [Header("Limiter for Crane")]
    private Transform craneTransform;
    public Transform movementLimitX1;
    public Transform movementLimitX2;
    public Transform movementLimitZ1;
    public Transform movementLimitZ2;


    private void Start()
    {
        craneTransform = craneGo.GetComponent<Transform>();
    }

    public void CheckPosition()
    {
        if(craneTransform.position.x <= movementLimitX1.position.x)
        {
            craneTransform.position = new Vector3(movementLimitX1.position.x, craneTransform.position.y, craneTransform.position.z);
        }else if(craneTransform.position.x >= movementLimitX2.position.x)
        {
            craneTransform.position = new Vector3(movementLimitX2.position.x, craneTransform.position.y, craneTransform.position.z);
        }else if(craneTransform.position.z <= movementLimitZ1.position.z)
        {
            craneTransform.position = new Vector3(craneTransform.position.x, craneTransform.position.y, movementLimitZ1.position.z);
        }else if(craneTransform.position.z >= movementLimitZ2.position.z)
        {
            craneTransform.position = new Vector3(craneTransform.position.x, craneTransform.position.y, movementLimitZ2.position.z);
        }
    }

    private void Update()
    {
        CheckPosition();
    }
}
