using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_at : MonoBehaviour
{
    public Transform Target;
    private void Update()
    {
        Vector3 direction = -(Target.position - transform.position);
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }
}