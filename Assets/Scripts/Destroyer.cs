using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    public Transform spawner;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plane")
        {
            GameObject hi = other.gameObject;
           
            var spawnObject=Instantiate(hi);
         Destroy(other.gameObject);
            spawnObject.transform.position = spawner.position;
        }
    }

}
