using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    public Transform spawner;
    public GameObject[] bridges;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plane")
        {
            Destroy(other.gameObject);
            int randomIndex = Random.Range(0, bridges.Length);
            var spawnObject = Instantiate(bridges[randomIndex]);
            spawnObject.transform.position = spawner.position;
            spawnObject.GetComponent<Movement>().Destroyer= this.transform;
                }
    }

}
