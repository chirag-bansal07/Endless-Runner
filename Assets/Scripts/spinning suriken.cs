using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spinningsuriken : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed;
    // Update is called once per frame
    void Update()
    {
     transform.Rotate(0,this.transform.rotation.y + speed,0);
    }
}
