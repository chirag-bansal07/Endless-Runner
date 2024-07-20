using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Transform Destroyer;
    void Update()
    {
        float step=speed* Time.fixedDeltaTime;
        this.transform.position = Vector3.MoveTowards(transform.position, Destroyer.position, step); 
           
    }
}
