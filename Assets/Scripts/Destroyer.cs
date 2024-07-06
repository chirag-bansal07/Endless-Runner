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
            GameObject ObjwctToBeSpawned = other.gameObject;
           
            var spawnObject=Instantiate(ObjwctToBeSpawned);
         Destroy(other.gameObject);
            spawnObject.transform.position = spawner.position;
        }
    }

}
