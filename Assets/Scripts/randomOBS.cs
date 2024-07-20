using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomOBS : MonoBehaviour 
{
    // Start is called before the first frame update
    public GameObject[] obstacles;
    public Transform[] position;

    void Start()
    {
        for (int i = 0; i < position.Length; i++)
        {
            int randomIndex = Random.Range(0, obstacles.Length);
            var spawnobs = Instantiate(obstacles[randomIndex], position[i]);
            spawnobs.transform.localPosition = Vector3.zero;
           
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
