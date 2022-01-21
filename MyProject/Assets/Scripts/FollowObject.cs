using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{

    [SerializeField]
    Transform target;
    
    void Update()
    {
        Vector3 pos = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = pos;
    }
}